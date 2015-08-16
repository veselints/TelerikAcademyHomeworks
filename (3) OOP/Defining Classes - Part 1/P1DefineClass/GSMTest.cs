// P1. Define class

// Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
// Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

//P2. Constructors

// Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
// Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

// P3. Enumeration
// Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

// P.4 ToString
// Add a method in the GSM class for displaying all information about it.
// Try to override ToString().

// P5. Properties

// Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
// Ensure all fields hold correct data at any given time.

// P6. Static field

// Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

// P7. GSM test

// Write a class GSMTest to test the GSM class:
// Create an array of few instances of the GSM class.
// Display the information about the GSMs in the array.
// Display the information about the static property IPhone4S.

// Problem 8. Calls

// Create a class Call to hold a call performed through a GSM.
// It should contain date, time, dialled phone number and duration (in seconds).


// P9. Call history

// Add a property CallHistory in the GSM class to hold a list of the performed calls.
// Try to use the system class List<Call>.

// P10. Add/Delete calls

// Add methods in the GSM class for adding and deleting calls from the calls history.
// Add a method to clear the call history.

// P11. Call price

// Add a method that calculates the total price of the calls in the call history.
// Assume the price per minute is fixed and is provided as a parameter.

// P12. Call history test

// Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
// Create an instance of the GSM class.
// Add few calls.
// Display the information about the calls.
// Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
// Remove the longest call from the history and calculate the total price again.
// Finally clear the call history and print it.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1DefineClass
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM[] GSMArray = new GSM[3];

            GSMArray[0] = new GSM("GXM-510", "Samsung", "Ivan", 540.50, new Battery("Rx_tgr", new TimeSpan(5, 06, 0, 0), BatteryType.Li_Ion), new Display(256));
            GSMArray[1] = new GSM("C3_pr34", "HTC", "Pesho", 40.50, new Battery("Tx-435", new TimeSpan(2, 08, 0, 0), BatteryType.NiCdi), new Display(16));
            GSMArray[2] = new GSM("Nexus 4", "LG", "Vlado", 340.50, new Battery("C4-rgd", new TimeSpan(3, 06, 0, 0), BatteryType.Li_Ion), new Display(16000000));

            foreach (var phone in GSMArray)
            {
                phone.DisplayGSMInfo();
            }

            GSM IPhone = GSM.IPhone4S;
            IPhone.DisplayGSMInfo();

            Console.WriteLine();

            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}
