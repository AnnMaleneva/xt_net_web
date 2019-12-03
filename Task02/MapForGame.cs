using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class MapForGame
    {
        private int width;
        private int height;

        public MapForGame()
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }

        private List<IBonus> Bonus = new List<IBonus>();
 
        private List<IObstacles> Obstacles = new List<IObstacles>();

        private List<IEnemy> Enemies = new List<IEnemy>();


    }

    interface IBonus
    {
        void GiveBonus();
    }

    class Apple : IBonus
    {
        public void GiveBonus()
        {
            Console.WriteLine("Apple gave a bonus!");
        }
    }

    class Cherry : IBonus
    {
        public void GiveBonus()
        {
            Console.WriteLine("Cherry gave a bonus!");
        }
    }

    interface IObstacles
    {
        void StandStill();
    }

    class Tree : IObstacles
    {
        public void StandStill()
        {
            Console.WriteLine("I am a tree and I stand still. Go around me!");
        }
    }

    class Stone : IObstacles
    {
        public void StandStill()
        {
            Console.WriteLine("I am a stone and I stand still. Go around me!");
        }
    }
    class Wall : IObstacles
    {
        public void StandStill()
        {
            Console.WriteLine("You shall not paaaaaass!!!");
        }
    }


    interface IEnemy
    {
        void Move();
        void EatUser();
    }

    class Wolf : IEnemy
    {
        public void EatUser()
        {
            Console.WriteLine("I am a wolf and I'll will eat you, stupid human!");
        }

        public void Move()
        {
            Console.WriteLine("I will find you, human! Ahahaha!");
        }
    }

    class Bear : IEnemy
    {
        public void EatUser()
        {
            Console.WriteLine("I am a beat. I love to eat people for brealfast!");
        }

        public void Move()
        {
            Console.WriteLine("I will find you, human! Arrrrrrr!");
        }
    }

}
