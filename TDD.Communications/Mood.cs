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

            if (dislikeCount == 0 && likeCount > 0)
            {
                return OutCome.LIKE;
            }
            if(dislikeCount > 0 && likeCount == 0)
            {
                return OutCome.DISLIKE;
            }
            //fallback
            return OutCome.NEUTRAL;
            ///let input = {L, L, L, D, L L}
            //likecount = 4
            //dislikexout = 1
            //if(1 ==0 && 4>0) false so does not execute 


        }
    }
}
        