using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_2
{
    public class ProfOrent
    {
        public int IdProfOrent { get; set; }
        public string Name { get; set; }
       
        public List< QuestionsBase> QuestionsBase { get; set; }

    }

    public class Humanities : ProfOrent
    {
        public Humanities()
        {
           IdProfOrent =  (int) TypeProfOrent.Humanities ;
           Name = nameof(Humanities);
           QuestionsBase = new List<QuestionsBase>
           {
                new QuestionsBase () { Name= "вы гумонитарий ",  Ves = 0.3 , TypeProfOrent = TypeProfOrent.Humanities },
                new QuestionsBase () { Name= "вы гумонитарий ",  Ves = 0.3 , TypeProfOrent = TypeProfOrent.Humanities}
                //  todo: вытаскиваем вопросы  из  файла 
           };
        }

        public override string ToString()
        {
            return Name; 
        }

    }

    public  class Technical : ProfOrent
    {
        public Technical()
        {
            IdProfOrent = (int) TypeProfOrent.Technical;
            Name = nameof(Technical);
            QuestionsBase = new List<QuestionsBase>
            {
                new QuestionsBase () { Name= "технарь   ",  Ves = 0.3 , TypeProfOrent = TypeProfOrent.Technical },
                new QuestionsBase () { Name= "вы технарь ",  Ves = 0.3  , TypeProfOrent = TypeProfOrent.Technical}
                //  todo: вытаскиваем вопросы  из  файла 
            };
        }
    }


    public  enum TypeProfOrent
    {
          Humanities =1, Technical =2

    }

}
