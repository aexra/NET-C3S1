﻿using Lab4.Classes.Model.Base;

namespace Lab4.Classes.Model.Consumers;
internal class Kettle : ElectricConsumer
{
    public Kettle(double consumption = 3) : base(consumption)
    {

    }
}
