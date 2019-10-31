using System;
namespace Custom_Class_Assignment
{
    public class Character
    {
        //these are my member variables
        //attributes of a person

        string mEyeColor;
        string mHairColor;
        string mOccupation;
        decimal mHeight;
        decimal mWeight;




        public Character(string _EyeColor, string _HairColor, string _Occupation, decimal _Height, decimal _Weight)
        {
            mEyeColor = _EyeColor;
            mHairColor = _HairColor;
            mOccupation = _Occupation;
            mHeight = _Height;
            mWeight = _Weight;



        }

        //getters that retrieve the information
        public string GetEyes ()
        {
            return mEyeColor;
        }
        public string GetHair ()
        {
            return mHairColor;
        }
        public string GetJob()
        {
            return mOccupation;
        }
        public decimal GetHeight()
        {
            return mHeight;
        }
        public decimal GetWeight()
        {
            return mWeight;
        }

        //These are the setters that the user can set the information with
        //The setter takes the information from the user and constructs a character out of it.
        public void SetEyes (string _SetEyes)
        {
            this.mEyeColor = _SetEyes;
        }
        public void SetHair (string _SetHair)
        {
            this.mHairColor = _SetHair;
        }
        public void SetJob (string _SetJob)
        {
            this.mOccupation = _SetJob;
        }
        public void SetHeight (decimal _SetHeight)
        {
            this.mHeight = _SetHeight;
        }
        public void SetWeight (decimal _SetWeight)
        {
            this.mWeight = _SetWeight;
        }



    }
}
