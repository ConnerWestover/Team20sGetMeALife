﻿using GetMeALibrary.Model;
using GetMeALifeLibrary.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetMeALife.ViewModels
{
    public class EventDetailViewModel
    {
        public EventDetail eventDetail { get; set; }

        public bool isConfirmed { get; set; }

        public string name
        {
            get
            {
                return eventDetail.name;
            }
        }

        public string locationAddress
        {
            get
            {
                return eventDetail.locationaddress;
            }
        }

        public DateTime eventTime
        {
            get
            {
                return eventDetail.eventstart;
            }
        }
    }

    public class EventDetail : Event
    {
        public string TypeName
        {
            get
            {
                return Api.Get<EventType>("http://getmealife.azurewebsites.net/graphql", new EventType(), this.eventtypeid).name;
            }
        }
    }
}
