﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Olympics" in code, svc and config file together.
public class Olympics : IOlympics
{
    public Athlete GetAthlete(int id)
    {
        using( OlympicsEntities context = new OlympicsEntities())
        {
            return context.Athletes.Where(a => a.IdAthlete == id).FirstOrDefault();
        }
    }
}
