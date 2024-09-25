using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public void SetAge(int age) { this.age = age; }
        public int GetAge() { return age; }
        public void SetHeight(int height) { this.height = height; }
        public int GetHeight() { return height; }
        public void SetTreeAlive(bool treeAlive){ this.treeAlive = treeAlive; }
        public bool GetTreeAlive() { return treeAlive; }
        public int GetNumOranges(){ return numOranges; }
        public int GetOrangesEaten(){ return orangesEaten; }

        public void OneYearPasses()
        {

        }

        public void EatOrange(int count)
        {

        }
    }
}
