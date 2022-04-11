using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Represents a fishs info on seriously fish 
 * 
 */
namespace FishAuction
{
  class FishModel
  {
    public string fishName;//This is for future use if we want to store into data structure
    public string distribution;
    public string habitat;
    public string aquariumSize; //This will need to some converter method from mm to inches.
    public string maxStandardLength; //This will need a converter method.
    public string maintenance;
    public string waterContions;
    public string diet;
    public string behaviour;
    public string dimorphism;
    public string reproduction;
    public string otherInfo;
    //Base constructor for the class, set everything to null
    public FishModel()
    {
      fishName = " ";
      distribution = " ";
      habitat = " ";
      aquariumSize = " ";
      maxStandardLength = " ";
      waterContions = " ";
      diet = " ";
      behaviour = " ";
      dimorphism = " ";
      reproduction = " ";
      otherInfo = " ";
      maintenance = " ";

    }

    public FishModel(string name)
    {
      fishName = name;
      distribution = " ";
      habitat = " ";
      aquariumSize = " ";
      maxStandardLength = " ";
      waterContions = " ";
      diet = " ";
      behaviour = " ";
      dimorphism = " ";
      reproduction = " ";
      otherInfo = " ";
      maintenance = " ";

    }
    /*
     * Takes in the whole page info on species and sets the variable correctly. 
     * 
     */
    public void setValues(string s)
    {
      string[] info = s.Split('\n');
      //Disgusting for loop, but we have to check for all these strings and set the string above accodingly.
      for (int i = 0; i < s.Length; i++)
      {
        //Switch case is probably better but I hate dealing with c# syntax
        if (info[i].ToLower().Contains("distribution")) //Not going to deal with varience in case
        {
          this.distribution = info[i + 1];
          continue;
        }
        else if (info[i].ToLower().Contains("habitat")) //Not going to deal with varience in case
        {
          this.habitat = info[i + 1];
        }
        else if (info[i].ToLower().Contains("maximum standard length")) //Not going to deal with varience in case
        {
          this.maxStandardLength = info[i + 1]; //HELPER METHOD GOES HERE TO CONVERT MM TO INCHES
        }
        else if (info[i].ToLower().Contains("aquarium size")) //Not going to deal with varience in case
        {
          this.aquariumSize = info[i + 2]; //Skip pass the top section
        }
        else if (info[i].ToLower().Contains("maintenance")) //Not going to deal with varience in case
        {
          this.maintenance = info[i + 1];
        }
        else if (info[i].ToLower().Contains("water conditions")) //Not going to deal with varience in case
        {
          this.waterContions = info[i + 1];
        }
        else if (info[i].ToLower().Contains("diet")) //Not going to deal with varience in case
        {
          this.diet = info[i + 1];
        }
        else if (info[i].ToLower().Contains("behaviour and compatibility")) //Not going to deal with varience in case
        {
          this.behaviour = info[i + 2]; //Skip top
        }
        else if (info[i].ToLower().Contains("sexual dimorphism")) //Not going to deal with varience in case
        {
          this.dimorphism = info[i + 1];
        }
        else if (info[i].ToLower().Contains("reproduction")) //Not going to deal with varience in case
        {
          this.reproduction = info[i + 1];
        }
        else if (info[i].ToLower().Contains("notes")) //Not going to deal with varience in case
        {
          this.otherInfo = info[i + 2];
        }
      }

      

    }
    /*
     * Clear method is needed for current implementation but if stored into 
     * data strucre is not needed and retrieved later
     * 
     */
    public void clear()
    {
      distribution = " ";
      habitat = " ";
      aquariumSize = " ";
      maxStandardLength = " ";
      waterContions = " ";
      diet = " ";
      behaviour = " ";
      dimorphism = " ";
      reproduction = " ";
      otherInfo = " ";
      maintenance = " ";

    }
  }
}
