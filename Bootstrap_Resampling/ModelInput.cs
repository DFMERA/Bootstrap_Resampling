﻿using Microsoft.ML.Data;

namespace Bootstrap_Resampling
{
    public class ModelInput
    {
        [ColumnName("id"), LoadColumn(0)]
        public float Id { get; set; }


        [ColumnName("lead_time"), LoadColumn(1)]
        public float Lead_time { get; set; }


        [ColumnName("arrival_date_month"), LoadColumn(2)]
        public string Arrival_date_month { get; set; }


        [ColumnName("arrival_date_day_of_month"), LoadColumn(3)]
        public float Arrival_date_day_of_month { get; set; }


        [ColumnName("stays_in_weekend_nights"), LoadColumn(4)]
        public float Stays_in_weekend_nights { get; set; }


        [ColumnName("stays_in_week_nights"), LoadColumn(5)]
        public float Stays_in_week_nights { get; set; }


        [ColumnName("adults"), LoadColumn(6)]
        public float Adults { get; set; }


        [ColumnName("children"), LoadColumn(7)]
        public float Children { get; set; }


        [ColumnName("reserved_room_type"), LoadColumn(8)]
        public float Reserved_room_type { get; set; }


        [ColumnName("rate"), LoadColumn(9)]
        public float Rate { get; set; }
    }
}