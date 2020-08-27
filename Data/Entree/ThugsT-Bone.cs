/*
 * Author: Christian Moden
 * Class name: ThusgsT-Bone.cs
 * Purpose: Class used to represent the Thusgs T-Bone and it's properties
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsT_Bone
    {
        /// <summary>
        /// Price property for the T-Bone
        /// </summary>
        public double Price => 6.44;
        /// <summary>
        /// Calories property for T-Bone
        /// </summary>
        public uint Calories => 982;
        /// <summary>
        /// Special instructions list for the tBone, will return an empty list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                return list;
            }
        }
        /// <summary>
        /// Overrrides defualt ToString method with string specific to class
        /// </summary>
        /// <returns>"Thusgs T-Bone" string</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
