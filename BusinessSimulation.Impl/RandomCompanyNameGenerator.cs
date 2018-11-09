using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public static class RandomCompanyNameGenerator
    {
        private static Random _random = new Random();
        private static List<string> _candidatesNames = new List<string> {
            "CHAD",
                    /**
         * Shop Food,
Shop Food Programme,
En ce moment Shop Food,
Metro Shop Food,
Dépendance Shop Food,
Dynamique Shop Food,
Shop Food Hybrid,
Solo Shop Food,
Shop Food Excellent,
Magnat Shop Food,
Super- Shop Food,
Gratuit Shop Food,
Panache Shop Food,
Shop Food Sécurité,
Star Shop Food,
Océan bleu Shop Food,
Chien rouge Shop Food,
Développer Shop Food,
Shop Food Note,
Forrest Shop Food,
Shop Food Groupe,
Cote est Shop Food,
OffTheGrid Shop Food,
Shop Food Recherche,
Bumblebee Shop Food,
Jour Shop Food,
Prochains Shop Food,
Repenser Shop Food,
Resonance Shop Food,
Concorde Shop Food,
Shop Food Génial,
Arbitrage Shop Food,
Shop Food Sierra,
Vue sur la baie Shop Food,
Camelot Shop Food,
Mutuel Shop Food,
Percée Shop Food,
Shop Food Chien,
Nord Ouest Shop Food,
Centurion Shop Food,
Composé Shop Food,
Shop Food Savers,
Shop Food Ivy,
SunValley Shop Food,
Plexus Shop Food,
Maxi Shop Food,
Jonction Shop Food,
Shop Food Cachet,
Taureau Shop Food,
Diligent Shop Food,
Suite Shop Food,
Shop Food Commentaires,
Shop Food Évaluations,
Nouveauté Shop Food,
Shop Food Spécial,
Offshore Shop Food,
Majeur Shop Food,
Shop Food Excursion,
Shop Food Atelier,
Nouvelle vague Shop Food
    **/
        };

        public static string Generate()
        {
            return _candidatesNames[_random.Next(0, _candidatesNames.Count)];
        }
    }
}
