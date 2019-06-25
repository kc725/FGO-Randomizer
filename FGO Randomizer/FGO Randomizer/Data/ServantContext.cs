using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FGO_Randomizer.Models
{
    public class ServantContext : DbContext
    {
        public ServantContext (DbContextOptions<ServantContext> options)
            : base(options)
        {
        }

        public DbSet<FGO_Randomizer.Models.Servant> Servant { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servant>().HasData(
                new Servant
                {
                    Id = 1,
                    Name = "Mash Kyrielight",
                    Class = "Shielder",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 2,
                    Name = "Artoria Pendragon",
                    Class = "Saber",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 3,
                    Name = "Artoria Pendragon (Alter)",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 4,
                    Name = "Artoria Pendragon (Lily)",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 5,
                    Name = "Nero Claudius",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 6,
                    Name = "Siegfried",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 7,
                    Name = "Gaius Julius Caesar",
                    Class = "Saber",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "H"
                },
                new Servant
                {
                    Id = 8,
                    Name = "Altera",
                    Class = "Saber",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 9,
                    Name = "Gilles de Rais (Saber)",
                    Class = "Saber",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "X"
                },
                new Servant
                {
                    Id = 10,
                    Name = "Chevalier d'Eon",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 11,
                    Name = "EMIYA",
                    Class = "Archer",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 12,
                    Name = "Gilgamesh",
                    Class = "Archer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 13,
                    Name = "Robin Hood",
                    Class = "Archer",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 14,
                    Name = "Atalanta",
                    Class = "Archer",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 15,
                    Name = "Euryale",
                    Class = "Archer",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 16,
                    Name = "Arash",
                    Class = "Archer",
                    Rarity = 1,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 17,
                    Name = "Cu Chulainn",
                    Class = "Lancer",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 18,
                    Name = "Elizabeth Bathory",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 19,
                    Name = "Musashibo Benkei",
                    Class = "Lancer",
                    Rarity = 2,
                    NA = true,
                    Card = 'A',
                    Role = "X"
                },
                new Servant
                {
                    Id = 20,
                    Name = "Cu Chulainn (Prototype)",
                    Class = "Lancer",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 21,
                    Name = "Leonidas I",
                    Class = "Lancer",
                    Rarity = 2,
                    NA = true,
                    Card = 'B',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 22,
                    Name = "Romulus",
                    Class = "Lancer",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 23,
                    Name = "Medusa",
                    Class = "Rider",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 24,
                    Name = "Georgios",
                    Class = "Rider",
                    Rarity = 2,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 25,
                    Name = "Edward Teach",
                    Class = "Rider",
                    Rarity = 2,
                    NA = true,
                    Card = 'B',
                    Role = "H"
                },
                new Servant
                {
                    Id = 26,
                    Name = "Boudica",
                    Class = "Rider",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 27,
                    Name = "Ushiwakamaru",
                    Class = "Rider",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 28,
                    Name = "Alexander",
                    Class = "Rider",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "H"
                },
                new Servant
                {
                    Id = 29,
                    Name = "Marie Antoinette",
                    Class = "Rider",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "H"
                },
                new Servant
                {
                    Id = 30,
                    Name = "Martha",
                    Class = "Rider",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "H"
                },
                new Servant
                {
                    Id = 31,
                    Name = "Medusa",
                    Class = "Caster",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 32,
                    Name = "Gilles de Rais (Caster)",
                    Class = "Caster",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "X"
                },
                new Servant
                {
                    Id = 33,
                    Name = "Hans Christian Andersen",
                    Class = "Caster",
                    Rarity = 2,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 34,
                    Name = "William Shakespeare",
                    Class = "Caster",
                    Rarity = 2,
                    NA = true,
                    Card = 'B',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 35,
                    Name = "Mephistopheles",
                    Class = "Caster",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "X"
                },
                new Servant
                {
                    Id = 36,
                    Name = "Wolfgang Amadeus Mozart",
                    Class = "Caster",
                    Rarity = 1,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 37,
                    Name = "Zhuge Liang (Lord El-Melloi II)",
                    Class = "Caster",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 38,
                    Name = "Cu Chulainn (Caster)",
                    Class = "Caster",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 39,
                    Name = "Sasaki Kojiro",
                    Class = "Assassin",
                    Rarity = 1,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 40,
                    Name = "Hassan of the Cursed Arm",
                    Class = "Assassin",
                    Rarity = 2,
                    NA = true,
                    Card = 'Q',
                    Role = "H"
                },
                new Servant
                {
                    Id = 41,
                    Name = "Stheno",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "X"
                },
                new Servant
                {
                    Id = 42,
                    Name = "Jing Ke",
                    Class = "Assassin",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 43,
                    Name = "Charles-Henri Sanson",
                    Class = "Assassin",
                    Rarity = 2,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 44,
                    Name = "Phantom of the Opera",
                    Class = "Assassin",
                    Rarity = 2,
                    NA = true,
                    Card = 'A',
                    Role = "X"
                },
                new Servant
                {
                    Id = 45,
                    Name = "Mata Hari",
                    Class = "Assassin",
                    Rarity = 1,
                    NA = true,
                    Card = 'Q',
                    Role = "X"
                },
                new Servant
                {
                    Id = 46,
                    Name = "Carmilla",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 47,
                    Name = "Heracles",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 48,
                    Name = "Lancelot",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 49,
                    Name = "Lu Bu Fengxian",
                    Class = "Berserker",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 50,
                    Name = "Spartacus",
                    Class = "Berserker",
                    Rarity = 1,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 51,
                    Name = "Sakata Kintoki",
                    Class = "Berserker",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 52,
                    Name = "Vlad III",
                    Class = "Berserker",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 53,
                    Name = "Asterios",
                    Class = "Berserker",
                    Rarity = 1,
                    NA = true,
                    Card = 'A',
                    Role = "X"

                },
                new Servant
                {
                    Id = 54,
                    Name = "Caligula",
                    Class = "Berserker",
                    Rarity = 2,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 55,
                    Name = "Darius III",
                    Class = "Berserker",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 56,
                    Name = "Kiyohime",
                    Class = "Berserker",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 57,
                    Name = "Eric Bloodaxe",
                    Class = "Berserker",
                    Rarity = 2,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 58,
                    Name = "Tamamo Cat",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 59,
                    Name = "Jeanne d'Arc",
                    Class = "Ruler",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 60,
                    Name = "Orion",
                    Class = "Archer",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 61,
                    Name = "Elizabeth Bathory (Halloween)",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 62,
                    Name = "Tamamo no Mae",
                    Class = "Caster",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 63,
                    Name = "David",
                    Class = "Archer",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 64,
                    Name = "Hector",
                    Class = "Lancer",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "H"
                },
                new Servant
                {
                    Id = 65,
                    Name = "Francis Drake",
                    Class = "Rider",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 66,
                    Name = "Anne Bonny & Mary Read",
                    Class = "Rider",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 67,
                    Name = "Medea (Lily)",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 68,
                    Name = "Okita Souji",
                    Class = "Saber",
                    Rarity = 5,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 69,
                    Name = "Oda Nobunaga",
                    Class = "Archer",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 70,
                    Name = "Scathach",
                    Class = "Lancer",
                    Rarity = 5,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 71,
                    Name = "Diarmuid Ua Duibhne",
                    Class = "Lancer",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 72,
                    Name = "Fergus mac Roich",
                    Class = "Saber",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 73,
                    Name = "Artoria Pendragon (Santa Alter)",
                    Class = "Rider",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 74,
                    Name = "Nursery Rhyme",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 75,
                    Name = "Jack the Ripper",
                    Class = "Assassin",
                    Rarity = 5,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 76,
                    Name = "Mordred",
                    Class = "Saber",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 77,
                    Name = "Nikola Tesla",
                    Class = "Archer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 78,
                    Name = "Artoria Pendragon (Lancer Alter)",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 79,
                    Name = "Paracelsus von Hohenheim",
                    Class = "Caster",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },
                new Servant
                {
                    Id = 80,
                    Name = "Charles Babbage",
                    Class = "Caster",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 81,
                    Name = "Henry Jekyll & Hyde",
                    Class = "Assassin",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "X"
                },
                new Servant
                {
                    Id = 82,
                    Name = "Frankenstein",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 84,
                    Name = "Arjuna",
                    Class = "Archer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 85,
                    Name = "Karna",
                    Class = "Lancer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 86,
                    Name = "Mysterious Heroine X",
                    Class = "Assassin",
                    Rarity = 5,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 87,
                    Name = "Fionn mac Cumhaill",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },
                new Servant
                {
                    Id = 88,
                    Name = "Brynhildr",
                    Class = "Lancer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 89,
                    Name = "Beowulf",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },
                new Servant
                {
                    Id = 90,
                    Name = "Nero Claudius (Bride)",
                    Class = "Saber",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "H"
                },

                new Servant
                {
                    Id = 91,
                    Name = "Ryougi Shiki (Saber)",
                    Class = "Saber",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 92,
                    Name = "Ryougi Shiki (Assassin)",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 93,
                    Name = "Amakusa Shirou",
                    Class = "Ruler",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "H"
                },

                new Servant
                {
                    Id = 94,
                    Name = "Astolfo",
                    Class = "Rider",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 95,
                    Name = "Gilgamesh (Child)",
                    Class = "Archer",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 96,
                    Name = "Edmond Dantès",
                    Class = "Avenger",
                    Rarity = 5,
                    NA = true,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 97,
                    Name = "Nightingale",
                    Class = "Berserker",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "Support"
                },

                new Servant
                {
                    Id = 98,
                    Name = "Cu Chulainn (Alter)",
                    Class = "Berserker",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 99,
                    Name = "Medb",
                    Class = "Rider",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 100,
                    Name = "Helena Blavatsky",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "H"
                },

                new Servant
                {
                    Id = 101,
                    Name = "Rama",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 102,
                    Name = "Li Shuwen (Lancer)",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 103,
                    Name = "Thomas Edison",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "X"
                },

                new Servant
                {
                    Id = 104,
                    Name = "Geronimo",
                    Class = "Caster",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "H"
                },

                new Servant
                {
                    Id = 105,
                    Name = "Billy the Kid",
                    Class = "Archer",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 106,
                    Name = "Jeanne d'Arc (Alter)",
                    Class = "Avenger",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 107,
                    Name = "Angra Mainyu",
                    Class = "Avenger",
                    Rarity = 2,
                    NA = true,
                    Card = 'Q',
                    Role = "X"
                },

                new Servant
                {
                    Id = 108,
                    Name = "Iskandar",
                    Class = "Rider",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 109,
                    Name = "EMIYA (Assassin)",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 110,
                    Name = "Hundred Face Hassan",
                    Class = "Assassin",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 111,
                    Name = "Irisviel (Dress of Heaven)",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "Support"
                },

                new Servant
                {
                    Id = 112,
                    Name = "Shuten Douji",
                    Class = "Assassin",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 113,
                    Name = "Xuanzang Sanzang",
                    Class = "Caster",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 114,
                    Name = "Minamoto no Raikou",
                    Class = "Berserker",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 115,
                    Name = "Sakata Kintoki (Rider)",
                    Class = "Rider",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 116,
                    Name = "Ibaraki Douji",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 117,
                    Name = "Fuma Kotarou",
                    Class = "Assassin",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "X"
                },

                new Servant
                {
                    Id = 118,
                    Name = "Ozymandias",
                    Class = "Rider",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "H"
                },

                new Servant
                {
                    Id = 119,
                    Name = "Artoria Pendragon (Lancer)",
                    Class = "Lancer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 120,
                    Name = "Nitocris",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 121,
                    Name = "Lancelot (Saber)",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 122,
                    Name = "Tristan",
                    Class = "Archer",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "H"
                },

                new Servant
                {
                    Id = 123,
                    Name = "Gawain",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 124,
                    Name = "Hassan of Serenity",
                    Class = "Assassin",
                    Rarity = 3,
                    NA = true,
                    Card = 'A',
                    Role = "X"
                },

                new Servant
                {
                    Id = 125,
                    Name = "Tawara Touta",
                    Class = "Archer",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 126,
                    Name = "Bedivere",
                    Class = "Saber",
                    Rarity = 3,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 127,
                    Name = "Leonardo Da Vinci",
                    Class = "Caster",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 128,
                    Name = "Tamamo no Mae (Lancer)",
                    Class = "Lancer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 129,
                    Name = "Artoria Pendragon (Archer)",
                    Class = "Archer",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 130,
                    Name = "Marie Antoinette (Caster)",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "H"
                },

                new Servant
                {
                    Id = 131,
                    Name = "Anne Bonny & Mary Read (Archer)",
                    Class = "Archer",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 132,
                    Name = "Mordred (Rider)",
                    Class = "Rider",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 133,
                    Name = "Scathach (Assassin)",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 134,
                    Name = "Kiyohime (Lancer)",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 135,
                    Name = "Martha (Ruler)",
                    Class = "Ruler",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 136,
                    Name = "Illyasviel von Einzbern",
                    Class = "Caster",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST",
                },

                new Servant
                {
                    Id = 137,
                    Name = "Chloe von Einzbern",
                    Class = "Archer",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 138,
                    Name = "Elizabeth Bathory (Brave)",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "X"
                },

                new Servant
                {
                    Id = 139,
                    Name = "Cleopatra",
                    Class = "Assassin",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 140,
                    Name = "Vlad III (EXTRA)",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 141,
                    Name = "Jeanne d'Arc Alter Santa Lily",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "H"
                },

                new Servant
                {
                    Id = 142,
                    Name = "Ishtar",
                    Class = "Archer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 143,
                    Name = "Enkidu",
                    Class = "Lancer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 144,
                    Name = "Quetzalcoatl",
                    Class = "Rider",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 145,
                    Name = "Gilgamesh (Caster)",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "H"
                },

                new Servant
                {
                    Id = 146,
                    Name = "Medusa (Lancer)",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 147,
                    Name = "Gorgon",
                    Class = "Avenger",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 148,
                    Name = "Jaguar Man",
                    Class = "Lancer",
                    Rarity = 3,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 150,
                    Name = "Merlin",
                    Class = "Caster",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 153,
                    Name = "Miyamoto Musashi",
                    Class = "Saber",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 154,
                    Name = "King Hassan",
                    Class = "Caster",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 155,
                    Name = "Mysterious Heroine X (Alter)",
                    Class = "Berserker",
                    Rarity = 5,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 156,
                    Name = "James Moriarty",
                    Class = "Archer",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 157,
                    Name = "EMIYA (Alter)",
                    Class = "Caster",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 158,
                    Name = "Hessian Lobo",
                    Class = "Avenger",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 159,
                    Name = "Yan Qing",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = true,
                    Card = 'Q',
                    Role = "X"
                },

                new Servant
                {
                    Id = 160,
                    Name = "Arthur Pendragon (Prototype)",
                    Class = "Saber",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 161,
                    Name = "Hijikata Toshizou",
                    Class = "Berserker",
                    Rarity = 5,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 162,
                    Name = "Chacha",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 163,
                    Name = "Meltryllis",
                    Class = "Alter Ego",
                    Rarity = 5,
                    NA = true,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 164,
                    Name = "Passionlip",
                    Class = "Alter Ego",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 165,
                    Name = "Suzuka Gozen",
                    Class = "Saber",
                    Rarity = 4,
                    NA = true,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 166,
                    Name = "BB",
                    Class = "Moon Cancer",
                    Rarity = 4,
                    NA = true,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 167,
                    Name = "Kiara Sesshouin",
                    Class = "Alter Ego",
                    Rarity = 5,
                    NA = true,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 169,
                    Name = "Scheherazade",
                    Class = "Caster",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 170,
                    Name = "Wu Zetian",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 171,
                    Name = "Penthesilea",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 172,
                    Name = "Christopher Columbus",
                    Class = "Rider",
                    Rarity = 3,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 173,
                    Name = "Sherlock Holmes",
                    Class = "Ruler",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "X"
                },

                new Servant
                {
                    Id = 174,
                    Name = "Paul Bunyan",
                    Class = "Berserker",
                    Rarity = 1,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 175,
                    Name = "Nero Claudius (Caster)",
                    Class = "Caster",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 176,
                    Name = "Frankenstein (Saber)",
                    Class = "Saber",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 177,
                    Name = "Nitocris (Assassin)",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 178,
                    Name = "Oda Nobunaga (Berserker)",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 179,
                    Name = "Artoria Pendragon (Rider Alter)",
                    Class = "Rider",
                    Rarity = 5,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 180,
                    Name = "Helena Blavatsky (Archer)",
                    Class = "Archer",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 181,
                    Name = "Minamoto no Raikou (Lancer)",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 182,
                    Name = "Ishtar (Rider)",
                    Class = "Rider",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 183,
                    Name = "Parvati",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "H"
                },

                new Servant
                {
                    Id = 184,
                    Name = "Tomoe Gozen",
                    Class = "Archer",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 185,
                    Name = "Mochizuki Chiyome",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "X"
                },

                new Servant
                {
                    Id = 186,
                    Name = "Houzouin Inshun",
                    Class = "Lancer",
                    Rarity = 3,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 187,
                    Name = "Yagyu Munenori",
                    Class = "Saber",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 188,
                    Name = "Katou Danzou",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "H"
                },

                new Servant
                {
                    Id = 189,
                    Name = "Osakabehime",
                    Class = "Assassin",
                    Rarity = 5,
                    NA = false,
                    Card = 'Q',
                    Role = "Support"
                },

                new Servant
                {
                    Id = 190,
                    Name = "Mecha Eli-chan",
                    Class = "Alter Ego",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 191,
                    Name = "Mecha Eli-chan Mk.II",
                    Class = "Alter Ego",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 192,
                    Name = "Circe",
                    Class = "Caster",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "H"
                },

                new Servant
                {
                    Id = 193,
                    Name = "Nezha",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 194,
                    Name = "Queen of Sheba",
                    Class = "Caster",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 195,
                    Name = "Abigail Williams",
                    Class = "Foreigner",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "X"
                },

                new Servant
                {
                    Id = 196,
                    Name = "Ereshkigal",
                    Class = "Lancer",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "H"
                },

                new Servant
                {
                    Id = 197,
                    Name = "Attila the San(ta)",
                    Class = "Archer",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 198,
                    Name = "Katsushika Hokusai",
                    Class = "Foreigner",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 199,
                    Name = "Semiramis",
                    Class = "Assassin",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 200,
                    Name = "Asagami Fujino",
                    Class = "Archer",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 201,
                    Name = "Anastasia Nikolaevna Romanova",
                    Class = "Caster",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 202,
                    Name = "Atalanta (Alter)",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 203,
                    Name = "Avicebron",
                    Class = "Caster",
                    Rarity = 3,
                    NA = false,
                    Card = 'A',
                    Role = "H"
                },

                new Servant
                {
                    Id = 204,
                    Name = "Antonia Salieri",
                    Class = "Avenger",
                    Rarity = 3,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 205,
                    Name = "Ivan the Terrible",
                    Class = "Rider",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 206,
                    Name = "Achilles",
                    Class = "Rider",
                    Rarity = 5,
                    NA = false,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 207,
                    Name = "Chiron",
                    Class = "Archer",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "H"
                },

                new Servant
                {
                    Id = 208,
                    Name = "Sieg",
                    Class = "Caster",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 209,
                    Name = "Okita Souji (Alter)",
                    Class = "Alter Ego",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 210,
                    Name = "Okada Izou",
                    Class = "Assassin",
                    Rarity = 3,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 211,
                    Name = "Sakamoto Ryouma",
                    Class = "Rider",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 212,
                    Name = "Napolean",
                    Class = "Archer",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 213,
                    Name = "Sigurd",
                    Class = "Saber",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 214,
                    Name = "Valkyrie",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 215,
                    Name = "Scathach-Skadi",
                    Class = "Caster",
                    Rarity = 5,
                    NA = false,
                    Card = 'Q',
                    Role = "Support"
                },

                new Servant
                {
                    Id = 216,
                    Name = "Jeanne d'Arc (Archer)",
                    Class = "Archer",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 217,
                    Name = "Ibaraki Douji (Lancer)",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 218,
                    Name = "Ushiwakamaru (Assassin)",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 219,
                    Name = "Jeanne d'Arc (Berserker Alter)",
                    Class = "Berserker",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 220,
                    Name = "BB (Summer)",
                    Class = "Moon Cancer",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "H"
                },

                new Servant
                {
                    Id = 221,
                    Name = "Medb (Saber)",
                    Class = "Saber",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "X"
                },

                new Servant
                {
                    Id = 222,
                    Name = "Mysterious Heroine XX",
                    Class = "Foreigner",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 223,
                    Name = "Diarmuid Ua Duibhne (Saber)",
                    Class = "Saber",
                    Rarity = 4,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 224,
                    Name = "Sitonai",
                    Class = "Alter Ego",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 225,
                    Name = "Shuten Douji (Caster)",
                    Class = "Caster",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 226,
                    Name = "Xiang Yu",
                    Class = "Berserker",
                    Rarity = 5,
                    NA = false,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 227,
                    Name = "Lanling Wang",
                    Class = "Saber",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "X"
                },

                new Servant
                {
                    Id = 228,
                    Name = "Qin Liangyu",
                    Class = "Lancer",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "X"
                },

                new Servant
                {
                    Id = 229,
                    Name = "Shi Huang Di",
                    Class = "Ruler",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "Support"
                },

                new Servant
                {
                    Id = 230,
                    Name = "Yu Miaoyi",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 231,
                    Name = "Red Hare",
                    Class = "Rider",
                    Rarity = 3,
                    NA = false,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 232,
                    Name = "Bradamante",
                    Class = "Lancer",
                    Rarity = 5,
                    NA = false,
                    Card = 'Q',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 233,
                    Name = "Quetzalcoatl (Samba/Santa)",
                    Class = "Ruler",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 234,
                    Name = "Beni-enma",
                    Class = "Saber",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "H"
                },

                new Servant
                {
                    Id = 235,
                    Name = "Li Shuwen (Assassin)",
                    Class = "Assassin",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 236,
                    Name = "Miyu Edelfelt",
                    Class = "Caster",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "Support"
                },

                new Servant
                {
                    Id = 237,
                    Name = "Murasaki Shikibu",
                    Class = "Caster",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 238,
                    Name = "Kingprotea",
                    Class = "Alter Ego",
                    Rarity = 5,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                },

                new Servant
                {
                    Id = 239,
                    Name = "Kama",
                    Class = "Assassin",
                    Rarity = 5,
                    NA = false,
                    Card = 'Q',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 241,
                    Name = "Sima Yi (Reines)",
                    Class = "Rider",
                    Rarity = 5,
                    NA = false,
                    Card = 'A',
                    Role = "Support"
                },

                new Servant
                {
                    Id = 242,
                    Name = "Astraea",
                    Class = "Ruler",
                    Rarity = 4,
                    NA = false,
                    Card = 'A',
                    Role = "ST"
                },

                new Servant
                {
                    Id = 243,
                    Name = "Gray",
                    Class = "Assassin",
                    Rarity = 4,
                    NA = false,
                    Card = 'B',
                    Role = "AOE"
                }
            );
        }
    }
}
