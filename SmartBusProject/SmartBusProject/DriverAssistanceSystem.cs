using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class DriverAssistanceSystem
    {
        public int currentSpeed {  get; set; }
        public int speedLimit { get; set; } = 50;

        public int speedViolationseconds = 0;
        public const int violationSecondsLimit = 3;
        private const int TiredSeconds = 30;

        public int BusLanePosition {  get; private set; } = 0;
        public int BusLaneLimit = 10;

        public int DriverIdle { get; private set; } = 0;
       
        public bool speedAlert {  get; private set; }
        public bool SpeedLocked = false;
        public bool Braking = false;
        public bool Accelarating = false;
        public bool LaneDeparture {  get; private set; } = false;

        public bool DriverTired { get; private set; } = false;

        public DriverAssistanceSystem()
        {
            currentSpeed = 0;
            speedAlert = false;
            SpeedLocked = false;
        }

        public void UpdateSpeed()
        {
            if (Accelarating && !SpeedLocked)
            {
                currentSpeed += 2;
            }
            if (Braking)
            {
                currentSpeed -= 3;
            }
            if(currentSpeed < 0) 
            {
                currentSpeed =  0;
            }

            CheckSpeedViolation();
        }

        public void CheckSpeedViolation()
        {
            if (currentSpeed > speedLimit)
            {
                speedViolationseconds++;
                if (speedViolationseconds >= violationSecondsLimit && !speedAlert)
                {
                    speedAlert = true;
                    SpeedLocked = true;

                    Accelarating = false;
                    SystemSounds.Exclamation.Play();
                }
            }
            else
            {
                ResetSpeedViolation();
            }
        }

        public void ResetSpeedViolation()
        {
            speedViolationseconds = 0;
            speedAlert = false;
            SpeedLocked = false;
        }

        public bool UpdateLanePosition()
        {
            if (BusLanePosition < -BusLaneLimit || BusLanePosition > BusLaneLimit)
            {
                if (!LaneDeparture)
                {
                    LaneDeparture = true;
                    SystemSounds.Beep.Play();
                    return true;
                }
            }
            else
            {
                LaneDeparture = false;
            }
            return false;
        }

        public bool UpdateTired()
        {
            bool driverActive = Accelarating || Braking || BusLanePosition != 0;
            if (driverActive) 
            {
                DriverIdle = 0;
                DriverTired = false;
                return false;
            }

            DriverIdle++;

            if (DriverIdle >= TiredSeconds && !DriverTired)
            {
                DriverTired = true;
                SystemSounds.Asterisk.Play();
                return true;
            }
            return false;
        }

        public void TurnLeft()
        {
            BusLanePosition -= 1;
        }

        public void TurnRight()
        {
            BusLanePosition += 1;
        }

        public void CenterLane()
        {
            if (BusLanePosition > 0) BusLanePosition--;
            else if (BusLanePosition < 0 ) BusLanePosition ++;
        }
    }
}
