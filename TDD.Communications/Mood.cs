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
            int likeCount = inputs.Count(o => o == OutCome.LIKE) % 2;
            int dislikeCount = inputs.Count(o => o == OutCome.DISLIKE) % 2;

            if(likeCount == 1 && dislikeCount ==1)
            {
                return OutCome.NEUTRAL;
            }

            if(likeCount == 1)
            {
                return OutCome.LIKE;
            }
            if (dislikeCount == 1)
            {
                return OutCome.DISLIKE;
            }

            return OutCome.NEUTRAL;

        }
    }
}
        