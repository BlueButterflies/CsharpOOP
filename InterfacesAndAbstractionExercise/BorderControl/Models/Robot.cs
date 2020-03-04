﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Robot : IIdentificableId
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; set; }

        public string Id { get; private set; }
    }
}
