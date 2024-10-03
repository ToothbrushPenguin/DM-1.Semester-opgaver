using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
   
    public class OrangeTree
    {
        private int age;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        private int height;
        public int Height
        {
            set { height = value; }
            get { return height; }
        }
        private bool treeAlive;
        public bool TreeAlive
        {
            set { treeAlive = value; }
            get { return treeAlive; }
        }
        private int numOranges;
        public int NumOranges
        {

            get { return numOranges; }
        }
        private int orangesEaten;
        public int OrangesEaten
        {

            get { return orangesEaten; }
        }

        public void OneYearPasses()
        {

            if (treeAlive)
            {
                numOranges = Age * 5;
            }
            else
            {
                numOranges = 0;
            }
                
            Age++;
            orangesEaten = 0;
            if (Age >= 80)
            {
                treeAlive = false;
            }
            else
            {
                height += 2;
                treeAlive = true;
            }
            
        }

        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten = orangesEaten + count;
                numOranges -= count;
            }

        }
    }
}
