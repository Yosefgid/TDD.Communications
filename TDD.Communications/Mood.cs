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
            //use of % will give us the final outcome after sequence of input, for example 5 Likes will have a remainder of 1 like at the end after cancellation
            int likeRemainder = inputs.Count(o => o == OutCome.LIKE) % 2;
            int dislikeRemainder = inputs.Count(o => o == OutCome.DISLIKE) % 2;

            if(likeRemainder == 1 && dislikeRemainder == 1)
            {
                return OutCome.NEUTRAL;
            }

            if(likeRemainder == 1)
            {
                return OutCome.LIKE;
            }
            if (dislikeRemainder == 1)
            {
                return OutCome.DISLIKE;
            }

            return OutCome.NEUTRAL;

        }
    }
}
        