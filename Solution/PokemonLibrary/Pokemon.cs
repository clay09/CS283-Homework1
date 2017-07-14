using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Pokemon
    {
        /// <summary>名稱</summary>
        public string Name { get; set; }

        /// <summary>性別</summary>
        public string Gender { get; set; }

        /// <summary>總血量</summary>
        public int Hp { get; set; }

        /// <summary>變動血量</summary>
        public int Cp { get; set; }

        /// <summary>體重</summary>
        public float Weight { get; set; }

        /// <summary>屬性</summary>
        public string Property { get; set; }

        /// <summary>身高</summary>
        public float Hieght { get; set; }

        /// <summary>星星沙子</summary>
        public int StarSand { get; set; }

        /// <summary>糖果</summary>
        public int Candy { get; set; }

        /// <summary>強化</summary>
        public Strengthening Strengthening { get; set; }

        /// <summary>進化</summary>
        public Evolution Evolution { get; set; }

        /// <summary>攻擊模式</summary>
        public List<Attack> AttackMode { get; set; }
    }

    /// <summary>強化</summary>
    public class Strengthening
    {
        /// <summary>星星沙子</summary>
        public int StarSand { get; set; }

        /// <summary>糖果</summary>
        public int Candy { get; set; }
    }

    /// <summary>進化</summary>
    public class Evolution
    {
        /// <summary>糖果</summary>
        public int Candy { get; set; }
    }

    /// <summary>攻擊模式</summary>
    public class Attack
    {
        /// <summary>模式</summary>
        public string Mode { get; set; }

        /// <summary>傷害</summary>
        public int Power { get; set; }
    }
}
