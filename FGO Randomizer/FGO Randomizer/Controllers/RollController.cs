using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using FGO_Randomizer.Models;
using System.Threading;


namespace FGO_Randomizer.Controllers
{
    public class RollController : Controller
    {
        private readonly ServantContext _context;

        public RollController(ServantContext context)
        {
            _context = context;
        }

        //INDEX
        //Initial, make a UserListViewModel to work with
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IQueryable<string> servantClasses = from s in _context.Servant
                                                orderby s.Class
                                                select s.Class;

            var servants = from s in _context.Servant select s;
            var servants_list = await servants.ToListAsync();
            var results = new UserListViewModel
            {
                Classes = new SelectList(await servantClasses.Distinct().ToListAsync()),
                ServantList = new List<ServantChecked>()
            };

            foreach (Servant s in servants_list)
            {
                var x = new ServantChecked { servant = s };
                results.ServantList.Add(x);
            }
            return View(results);
        }

        [HttpPost]
        public IActionResult Index([FromBody] UserListViewModel prev)
        {
            return View(prev);
        }

        //GO
        [HttpPost]
        public async Task<IActionResult> Go(UserListViewModel ulvm)
        {
            var chosen_servants = await get_chosen_servants(ulvm);
            if (chosen_servants.Count < 6) { return View(chosen_servants); }

            var class_advantages = ClassAdvantageOf(ulvm.enemyClass);
            var results = new List<Servant>();

            if (ulvm.difficulty == 1)
            {
                var A = chosen_servants.Where(x => class_advantages.Contains(x.Class)).ToList();
                A.Shuffle();
                chosen_servants = chosen_servants.Except(A).ToList();
                chosen_servants.Shuffle();
                results = A.GetRange(0, 3).Concat(chosen_servants.GetRange(0, 2)).ToList();
            }
            
            else if (ulvm.difficulty == 3)
            {
                results = chosen_servants.Where(x => !class_advantages.Contains(x.Class)).ToList();
            }

            else
            {
                results = chosen_servants;   
            }

            results.Shuffle();
            return View(results.GetRange(0,5));
        }

        //Draft
        [HttpPost]
        public async Task<IActionResult> Draft(UserListViewModel ulvm)
        {
            var chosen_servants = await get_chosen_servants(ulvm);
            List<List<Servant>> result = new List<List<Servant>>();

            var class_advantages = ClassAdvantageOf(ulvm.enemyClass);

            List<Servant> A = new List<Servant>(chosen_servants);
            if (!class_advantages.Contains("All") && ulvm.difficulty != 2)
            {
                if(ulvm.difficulty == 1)
                {
                    A = A.Where(x => class_advantages.Contains(x.Class)).ToList();
                }
                else
                {
                    A = A.Where(x => !class_advantages.Contains(x.Class)).ToList();
                }
            }
            A.Shuffle();
            A = A.GetRange(0, 4);
            chosen_servants = chosen_servants.Except(A).ToList();
            result.Add(A);

            List<Servant> B = new List<Servant>(chosen_servants);
            if (!class_advantages.Contains("All") && ulvm.difficulty != 2)
            {
                if (ulvm.difficulty == 1)
                {
                    B = B.Where(x => class_advantages.Contains(x.Class)).ToList();
                }
                else
                {
                    B = B.Where(x => !class_advantages.Contains(x.Class)).ToList();
                }
            }
            B.Shuffle();
            B = B.GetRange(0, 4);
            chosen_servants = chosen_servants.Except(B).ToList();
            result.Add(B);

            var AB = A.Concat(B).ToList();
            var misRole = missingRole(AB);
            List<Servant> C = chosen_servants.Where(x => x.Role == misRole).ToList();
            C.Shuffle();
            C = C.GetRange(0, 4);
            chosen_servants = chosen_servants.Except(C).ToList();
            result.Add(C);

            var misRoleD = missingRole(AB.Concat(C).ToList());
            List<Servant> D = chosen_servants.Where(x => x.Role == misRoleD).ToList();
            if (!class_advantages.Contains("All") && ulvm.difficulty != 2)
            {
                if (ulvm.difficulty == 1)
                {
                    D = D.Where(x => class_advantages.Contains(x.Class)).ToList();
                }
                else
                {
                    D = D.Where(x => !class_advantages.Contains(x.Class)).ToList();
                }
            }
            D.Shuffle();
            D = D.GetRange(0, 4);
            chosen_servants = chosen_servants.Except(D).ToList();
            result.Add(D);

            chosen_servants.Shuffle();
            List<Servant> E = chosen_servants.GetRange(0, 4);
            result.Add(E);


            return View(result);
        }
    
        public async Task<List<Servant>> get_chosen_servants(UserListViewModel ulvm)
        {
            var given_servants = ulvm.ServantList;
            var chosen_servants = new List<Servant>();

            if (given_servants.Any())
            {
                foreach (ServantChecked s in given_servants)
                {
                    if (s.IsChecked)
                    {
                        chosen_servants.Add(s.servant);
                    }
                }
            }
            else
            {
                var servants = from s in _context.Servant select s;
                chosen_servants = await servants.ToListAsync();
            }
            return chosen_servants;
        }

        public List<string> ClassAdvantageOf(string Class)
        {
            List<string> result = new List<string>();
            if (Class == "All")
            {
                result.Add("All");
                return result;
            }

            result.Add("Berserker");
            
            if (Class == "Saber") { result.Add("Archer"); }
            if (Class == "Archer") { result.Add("Lancer"); }
            if (Class == "Lancer") { result.Add("Saber"); }

            if (Class == "Rider") { result.Add("Assassin"); result.Add("Alter Ego"); }
            if (Class == "Assassin") { result.Add("Caster"); result.Add("Alter Ego"); }
            if (Class == "Caster") { result.Add("Rider"); result.Add("Alter Ego"); }

            if (Class == "Ruler") { result.Add("Avenger"); }
            if (Class == "Avenger") { result.Add("Moon Cancer"); }
            if (Class == "Moon Cancer") { result.Add("Ruler"); }

            if (Class == "Foreigner") { result.Add("Alter Ego"); result.Remove("Berserker"); }
            if (Class == "Berserker") { result.Remove("Berserker"); result.Add("All"); }
            if (Class == "Alter Ego") { result.Add("Saber"); result.Add("Lancer"); result.Add("Archer"); }
            return result;
        }
        
        public string missingRole(List<Servant> prev)
        {
            Dictionary<string, int> Roles = new Dictionary<string, int>()
            {
                {"ST", 0 },
                {"AOE", 0 },
                {"H", 0 },
                {"Support", 0 },
                {"X", 0 }
            };

            foreach (Servant s in prev)
            {
                Roles[s.Role] += 1;
            }

            List<string> results = new List<string>();
            
            foreach (var (role, n) in Roles.Select(x => (x.Key, x.Value)))
            {
                if (n < 2) { results.Add(role); }
            }
            results.Shuffle();
            return results.ElementAt(0);
        }
    }
    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}