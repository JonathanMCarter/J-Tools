﻿using UnityEngine;

namespace JTools
{
    public static class DoubleExtension
    {
        /// <summary>
        /// Turns an int into a negative variant of that int or vise versa
        /// </summary>
        /// <param name="original">The value to edit.</param>
        /// <returns>Double</returns>
        public static double Invert(this double original)
        {
            return original * -1;
        }

        
        /// <summary>
        /// Floors the value entered.
        /// </summary>
        /// <param name="original">The value to edit.</param>
        /// <returns>Int</returns>
        public static int FloorToInt(this double original)
        {
            return Mathf.FloorToInt((float) original);
        }
        
        
        /// <summary>
        /// Floors the value entered.
        /// </summary>
        /// <param name="original">The value to edit.</param>
        /// <returns>Double</returns>
        public static double Floor(this double original)
        {
            return Mathf.Floor((float) original);
        }
        
        
        /// <summary>
        /// Ceilings the value entered.
        /// </summary>
        /// <param name="original">The value to edit.</param>
        /// <returns>Int</returns>
        public static int CeilToInt(this double original)
        {
            return Mathf.CeilToInt((float) original);
        }
        
        
        /// <summary>
        /// Ceilings the value entered.
        /// </summary>
        /// <param name="original">The value to edit.</param>
        /// <returns>Double</returns>
        public static double Ceil(this double original)
        {
            return Mathf.Ceil((float) original);
        }
        
        
        /// <summary>
        /// Rounds the value entered.
        /// </summary>
        /// <param name="original">The value to edit.</param>
        /// <returns>Int</returns>
        public static int RoundToInt(this double original)
        {
            return Mathf.RoundToInt((float) original);
        }
        
        
        /// <summary>
        /// Rounds the value entered.
        /// </summary>
        /// <param name="original">The value to edit.</param>
        /// <returns>Double</returns>
        public static double Round(this double original)
        {
            return Mathf.Round((float) original);
        }
        
        
        /// <summary>
        /// Abs's the value entered.
        /// </summary>
        /// <param name="original">The value to edit.</param>
        /// <returns>Double</returns>
        public static double Abs(this double original)
        {
            return Mathf.Abs((float) original);
        }
    }
}