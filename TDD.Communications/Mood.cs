using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TDD.Communications
{
    public class Mood 
    {
        public OutCome EvaluateMoods(OutCome[] inputs)
        {
            int likeCount = inputs.Count(o => o == OutCome.LIKE);
            int dislikeCount = inputs.Count(o => o == OutCome.DISLIKE);


            if(likeCount % 2 == 0 || dislikeCount % 2 == 0)
            {
                return OutCome.NEUTRAL;
            }

            if(likeCount > 0 && dislikeCount == 0)
            {
                return OutCome.LIKE;
            }
            if (dislikeCount > 0 && likeCount == 0)
            {
                return OutCome.DISLIKE;
            }

            return OutCome.NEUTRAL;

        }
    }
}
        