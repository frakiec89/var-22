using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_2
{
    public  class Up1
    {
        

        List<ProfOrent> profOrents;

        Up1 ()
        {
            profOrents.Add(new Humanities());
            profOrents.Add(new Technical());      
        }

        private ProfOrent GetProfOrent (TypeProfOrent typeProfOrent  )
        {
            return profOrents.Single(x => x.IdProfOrent == (int)typeProfOrent); 
        }

        public  QuestionsBase GetQuestionsBase (TypeProfOrent typeProfOrent)
        {
            return GetProfOrent(typeProfOrent).QuestionsBase.Single(x => x.Id == 1);
        }
   
        private int  RandomGeneretic ()
        {
            Random random = new Random(DateTime.Today.Second);


            return random.Next(0, 1);

        }

    }
      

    
}
