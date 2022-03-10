using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class NotesStore
    {
        public NotesStore() { }

        Dictionary<string, string> noteMap = new Dictionary<string, string>();
        public void AddNote(string state, string name)
        {
            string stateName = getStateName(state);
            if (!string.IsNullOrEmpty(name))
            {
                if (stateName != "invalid")
                {
                    noteMap.Add(name, state);
                }
                else
                {
                    throw new Exception($"Invalid state {state}");
                }
            }
            else
            {
                throw new Exception("Name can not be empty");
            }
        }
        public List<string> GetNotes(string state)
        {
            string stateName = getStateName(state);
            if (stateName != "invalid")
            {
                List<string> lstState = new List<string>();
                foreach (KeyValuePair<string, string> kvp in noteMap)
                {
                    if (state == kvp.Value)
                        lstState.Add(kvp.Key);
                }
                return lstState;
            }
            else
            {
                throw new Exception($"Invalid state {state}");
            }
        }

        public string getStateName(string state)
        {
            string name = "";
            switch (state)
            {
                case "active":
                    name = "active";
                    break;
                case "completed":
                    name = "completed";
                    break;
                case "others":
                    name = "others";
                    break;
                default:
                    name = "invalid";
                    break;
            }
            return name;
        }
    }
    public class HackerRank_Test2
    {
        public static void Input()
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}

