﻿namespace VeterinaryStation.Helper
{

    public interface IEntity
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }

    }

}