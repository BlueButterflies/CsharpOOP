using MilitaryElite.Interfaces;
using MilitaryElite.Models;
using MilitaryElite.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Devices.Common;

namespace MilitaryElite.Core
{
    public class ReadCommand : IReadCommand
    {
        private Dictionary<int, ISoldier> soldiers;

        public ReadCommand()
        {
            this.soldiers = new Dictionary<int, ISoldier>();
        }
        public string Read(string[] command)
        {
            string soldierType = command[0];
            int id = int.Parse(command[1]);
            string firstName = command[2];
            string lastName = command[3];
            decimal salary = decimal.Parse(command[4]);

            ISoldier soldier = null;

            if (soldierType == "Private")
            {
                soldier = new Private(id, firstName, lastName, salary);

                this.soldiers.Add(id, soldier);

                return soldier.ToString();
            }
            else if (soldierType == "LieutenantGeneral")
            {
                Dictionary<int, IPrivate> privates = new Dictionary<int, IPrivate>();

                for (int i = 5; i < command.Length; i++)
                {
                    int soldierId = int.Parse(command[i]);

                    var currentSoldier = (IPrivate)soldiers[soldierId];

                    privates.Add(soldierId, currentSoldier);
                }

                soldier = new LieutenantGeneral(id, firstName, lastName, salary, privates);
            }
            else if (soldierType == "Engineer")
            {
                bool isValidCorps = Corps.TryParse<Corps>(command[5], out Corps corps);

                if (!isValidCorps)
                {
                    throw new Exception();
                }

                ICollection<IRepair> repairs = new List<IRepair>();

                for (int i = 6; i < command.Length; i += 2)
                {
                    string repairName = command[i];
                    int hours = int.Parse(command[i + 1]);

                    IRepair repair = new Repair(repairName, hours);

                    repairs.Add(repair);
                }

                soldier = new Engineer(id, firstName, lastName, salary, corps, repairs);
            }
            else if (soldierType == "Commando")
            {
                bool isValidCorps = Corps.TryParse<Corps>(command[5], out Corps corps);

                if (!isValidCorps)
                {
                    throw new Exception();
                }

                ICollection<IMission> missions = new List<IMission>();

                for (int i = 6; i < command.Length; i += 2)
                {
                    string missionName = command[i];
                    string missionState = command[i + 1];

                    bool isValidMissionState = State.TryParse<State>(command[5], out State stateResult);

                    if (!isValidMissionState)
                    {
                        continue;
                    }

                    IMission mission = new Mission(missionName, stateResult);

                    missions.Add(mission);
                }

                soldier = new Commando(id, firstName, lastName
                    , salary, corps, missions);
            }
            else if (soldierType == "Spy")
            {
                int codeNumber = int.Parse(command[4]);

                soldier = new Spy(id, firstName, lastName, codeNumber);
            }

            soldiers.Add(id, soldier);

            return soldier.ToString();
        }
    }
}
