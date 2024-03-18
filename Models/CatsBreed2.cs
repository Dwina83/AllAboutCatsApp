
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace AllAboutCatsApp.Models
{
    public class CatsBreed2
    {

        public Weight2 weight { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cfa_url { get; set; }
        public string vetstreet_url { get; set; }
        public string vcahospitals_url { get; set; }
        public string temperament { get; set; }
        public string origin { get; set; }
        public string country_codes { get; set; }
        public string country_code { get; set; }
        public string description { get; set; }
        public string life_span { get; set; }
        public int indoor { get; set; }
        public int lap { get; set; }
        public string alt_names { get; set; }
        public int adaptability { get; set; }
        public int affection_level { get; set; }
        public int child_friendly { get; set; }
        public int dog_friendly { get; set; }
        public int energy_level { get; set; }
        public int grooming { get; set; }
        public int health_issues { get; set; }
        public int intelligence { get; set; }
        public int shedding_level { get; set; }
        public int social_needs { get; set; }
        public int stranger_friendly { get; set; }
        public int vocalisation { get; set; }
        public int experimental { get; set; }
        public int hairless { get; set; }
        public int natural { get; set; }
        public int rare { get; set; }
        public int rex { get; set; }
        public int suppressed_tail { get; set; }
        public int short_legs { get; set; }
        public string wikipedia_url { get; set; }
        public int hypoallergenic { get; set; }
        public string reference_image_id { get; set; }
        public Image image { get; set; }
        public int cat_friendly { get; set; }
        public int bidability { get; set; }

        public string ConvertToStarRating(int rating)
        {
            switch (rating)
            {
                case 1:
                    return "★☆☆☆☆";
                case 2:
                    return "★★☆☆☆";
                case 3:
                    return "★★★☆☆";
                case 4:
                    return "★★★★☆";
                case 5:
                    return "★★★★★";
                default: return "No data available";

            }
        }

        internal Task<List<CatsBreed2>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public string IndoorRating => ConvertToStarRating(indoor);
        public string LapRating => ConvertToStarRating(lap);
        public string AdaptabilityRating => ConvertToStarRating(adaptability);
        public string AffectionLevelRating => ConvertToStarRating(affection_level);
        public string ChildFriendlyRating => ConvertToStarRating(child_friendly);
        public string DogFriendlyRating => ConvertToStarRating(dog_friendly);
        public string CatFriendlyRating => ConvertToStarRating(cat_friendly);
        public string StrangerFriendlyRating => ConvertToStarRating(stranger_friendly);
        public string EnergyLevelRating => ConvertToStarRating(energy_level);
        public string GroomingRating => ConvertToStarRating(grooming);
        public string HealthIssuesRating => ConvertToStarRating(health_issues);
        public string IntelligenceRating => ConvertToStarRating(intelligence);
        public string SheddingLevelRating => ConvertToStarRating(shedding_level);
        public string SocialNeedsRating => ConvertToStarRating(social_needs);
        public string VocalisationRating => ConvertToStarRating(vocalisation);
        public string ExperimentalRating => ConvertToStarRating(experimental);
        public string HairlessRating => ConvertToStarRating(hairless);
        public string NaturalRating => ConvertToStarRating(natural);
        public string RareRating => ConvertToStarRating(rare);
        public string SuppressedTailRating => ConvertToStarRating(suppressed_tail);
        public string ShortLegsRating => ConvertToStarRating(short_legs);
        public string HypoallergenicRating => ConvertToStarRating(hypoallergenic);



    }
    public class Weight2
    {
        public string imperial { get; set; }
        public string metric { get; set; }
    }

    public class Image
    {
        public string id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

   

}
