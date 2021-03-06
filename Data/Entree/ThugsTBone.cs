﻿/*
 * Author: Christian Moden
 * Class name: ThusgsT-Bone.cs
 * Purpose: Class used to represent the Thusgs T-Bone and it's properties
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// Price property for the T-Bone
        /// </summary>
        public override double Price => 6.44;
        /// <summary>
        /// Calories property for T-Bone
        /// </summary>
        public override uint Calories => 982;
        /// <summary>
        /// Special instructions list for the tBone, will return an empty list
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }
        }
        /// <summary>
        /// Description of the T-Bone
        /// </summary>
        public override string Description => "Juicy T-Bone, not much else to say.";
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
