using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    public class InitiateOrder
    {

        public int jobType { get; set; }

        public int destinationID { get; set; }

        public int originID { get; set; }

        public int quantity { get; set; }

        public string origin { get; set; }

        public string destination { get; set; }

        public int vanType { get;  set; }

        public InitiateOrder()
        {

        }

        public string VerifyUserInput()
        {
            bool isValid = false;
            if (jobType == 0 && quantity == 0)
            {
                isValid = true;
            }
            else if (jobType == 1 && quantity >= 0)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            if (origin == "Windsor" || origin == "windsor")
            {
                originID = 1;
                isValid = true;
            }
            else if (origin == "london" || origin == "London")
            {
                originID = 2;
                isValid = true;
            }
            else if (origin == "hamilton" || origin == "Hamilton")
            {
                originID = 3;
                isValid = true;
            }
            else if (origin == "Toronto" || origin == "toronto")
            {
                originID = 4;
                isValid = true;
            }
            else if (origin == "Oshawa" || origin == "oshawa")
            {
                originID = 5;
                isValid = true;
            }
            else if (origin == "Belleville" || origin == "belleville")
            {
                originID = 6;
                isValid = true;
            }
            else if (origin == "Kingston" || origin == "kingston")
            {
                originID = 7;
                isValid = true;
            }
            else
            {
                isValid = false;
            }


            if (destination == "Ottawa" || destination == "ottawa")
            {
                destinationID = 8;
                isValid = true;
            }
            else if (destination == "london" || destination == "London")
            {
                destinationID = 2;
                isValid = true;
            }
            else if (destination == "hamilton" || destination == "Hamilton")
            {
                destinationID = 3;
                isValid = true;
            }
            else if (destination == "Toronto" || destination == "toronto")
            {
                destinationID = 4;
                isValid = true;
            }
            else if (destination == "Oshawa" || destination == "oshawa")
            {
                destinationID = 5;
                isValid = true;
            }
            else if (destination == "Belleville" || destination == "belleville")
            {
                destinationID = 6;
                isValid = true;
            }
            else if (destination == "Kingston" || destination == "kingston")
            {
                destinationID = 7;
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            string ret = "";
            if (isValid == true)
            {
                if (jobType == 0)
                {
                    ret = "t" + CalculateFTLTime(originID, destinationID).ToString() + ",";
                    ret += "d" + CalculateDistance(originID, destinationID).ToString();
                }
                else
                {
                    ret = "t" + CalculateLTLTime(originID, destinationID).ToString() + ",";
                    ret += "d" + CalculateDistance(originID, destinationID).ToString();

                }

            }
            return ret;

        }

        public int CalculateFTLTime(int originID, int destinationID)
        {
            int totalTime = 0;
            int counter = 0;
            int loadingMinutes = 240;
            int[] Time = new int[7] { 150, 105, 75, 78, 99, 72, 150 };

            if (destinationID < originID)
            {
                counter = destinationID;

                while (counter <= originID)
                {
                    totalTime += Time[counter - 1];
                    counter++;
                }

            }
            else if (destinationID > originID)
            {
                counter = originID;

                while (counter <= destinationID)
                {
                    totalTime += Time[counter - 1];
                    counter++;
                }
            }

            totalTime += loadingMinutes;

            return totalTime;
        }

        public int CalculateDistance(int originID, int destinationID)
        {
            int totalDistance = 0;
            int counter = 0;

            int[] Distance = new int[7] { 191, 128, 68, 60, 134, 82, 196 };

            if (destinationID < originID)
            {
                counter = destinationID;
                while (counter <= originID)
                {
                    totalDistance += Distance[counter - 1];
                    counter++;
                }
            }
            else if (destinationID > originID)
            {
                counter = originID;
                while (counter <= destinationID)
                {
                    totalDistance += Distance[counter - 1];
                    counter++;
                }
            }
            return totalDistance;

        }

        public int CalculateLTLTime(int originID, int destinationID)
        {
            int totalTime = 0;
            int counter = 0;
            int totalHoldTime = 0;
            int loadingMinutes = 240;
            int convertHolding = 120;
            int[] Time = new int[7] { 150, 105, 75, 78, 99, 72, 150 };

            if (destinationID < originID)
            {
                counter = destinationID;

                while (counter <= originID)
                {
                    totalTime += Time[counter - 1];
                    counter++;
                }

                totalHoldTime = originID - destinationID - 1;

                totalHoldTime *= convertHolding;

                totalTime += totalHoldTime;

            }
            else if (destinationID > originID)
            {
                counter = originID;

                while (counter <= destinationID)
                {
                    totalTime += Time[counter - 1];
                    counter++;
                }

                totalHoldTime = destinationID - originID - 1;

                totalHoldTime *= convertHolding;

                totalTime += totalHoldTime;
            }


            totalTime += loadingMinutes;


            return totalTime;
        }
    }
}
