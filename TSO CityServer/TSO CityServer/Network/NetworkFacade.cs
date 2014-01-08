﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using GonzoNet;
using ProtocolAbstractionLibraryD;

namespace TSO_CityServer.Network
{
    public class NetworkFacade
    {
        public static SharedArrayList TransferringClients;

        static NetworkFacade()
        {
            TransferringClients = new SharedArrayList();
            PacketHandlers.Register(0x01, false, 0, new OnPacketReceive(LoginPacketHandlers.HandleClientToken));
            PacketHandlers.Register((byte)PacketType.CHARACTER_CREATE_CITY, false, 0, new OnPacketReceive(ClientPacketHandlers.HandleCharacterCreate));
            PacketHandlers.Register((byte)PacketType.CITY_TOKEN, false, 0, new OnPacketReceive(ClientPacketHandlers.HandleCityToken));
        }
    }
}