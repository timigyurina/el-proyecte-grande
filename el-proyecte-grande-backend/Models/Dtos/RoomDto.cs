﻿using el_proyecte_grande_backend.Models.Entities;
using el_proyecte_grande_backend.Models.Enums;

namespace el_proyecte_grande_backend.Models.Dtos
{
    public class RoomDto
    {
        public long Id { get; set; }
        public int Floor { get; set; }
        public int DoorNo { get; set; }
        public bool Accessible { get; set; }
        public RoomStatus Status { get; set; }

        public long HotelId { get; set; }
        public long RoomTypeId { get; set; }
        public List<long> ReservationIds { get; set; } = new();
    }
}
