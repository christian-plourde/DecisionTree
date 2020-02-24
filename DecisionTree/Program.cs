using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree
{
    class Character
    {
        public bool tired;
        public bool hungry;

        public Character()
        {
            
        }

        public bool IsTired()
        {
            return tired;
        }

        public bool IsHungry()
        {
            return hungry;
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

        public void EatAndSleep()
        {
            Eat();
            Sleep();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Character character = new Character();
            character.tired = true;
            character.hungry = true;
            CheckNode node = new CheckNode(character.IsTired);
            CheckNode n2 = new CheckNode(character.IsHungry);
            CheckNode n3 = new CheckNode(character.IsHungry);
            ActionNode n4 = new ActionNode(character.Sleep);
            ActionNode n5 = new ActionNode(character.Eat);
            ActionNode n6 = new ActionNode(character.Sleep);
            ActionNode n7 = new ActionNode(character.EatAndSleep);

            node.Left = n2;
            node.Right = n3;

            n2.Left = n4;
            n2.Right = n5;
            n3.Left = n6;
            n3.Right = n7;

            DecisionTree tree = new DecisionTree(node);
            tree.Evaluate();
            Console.ReadLine();

        }
    }
}
