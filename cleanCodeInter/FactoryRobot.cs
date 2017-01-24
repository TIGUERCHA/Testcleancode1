using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanCodeInter
{
    class FactoryRobot : Rebot, IRebot
    {
        public FactoryRobot(string code) : base(code)
        {
        }
        public void Task1(Rebot robot, string date)
        {
            base.activityRebot.Add(robot.Code.ToString() + ", Task1, " + date.ToString());
        }
        public void Task2(Rebot robot, string date)
        {
            base.activityRebot.Add(robot.Code.ToString() + ", Task2, " + date.ToString());
        }
        public void Task3(Rebot robot, string date)
        {
            base.activityRebot.Add(robot.Code.ToString() + ", Task3, " + date.ToString());
        }
    }
}
