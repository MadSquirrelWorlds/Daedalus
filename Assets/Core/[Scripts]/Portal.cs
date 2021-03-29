using System;
using UnityEngine;
using Utils.Extensions;

namespace Core
{
    public class Portal : RoomFeature
    {
        public GameObject prefab;
        
        public Portal destination;
        public Transform inbound;
        
        

        public override void Load()
        {
            base.Load();
            GameObject portal=Instantiate(prefab, transform);
            inbound = portal.GetComponentInChildren<SpawnpointTag>().transform;
        }

        public override void Enable()
        {
            base.Enable();
            
            room.roomTracker.RegisterPortal(this);
            string childRoomId;
            Pose childPose;
            if (!room.map.CheckPortal(room.id,out childRoomId,
                out childPose))
            {
                room.map.AddPortal(room.id, room.type, room.transform.getPose());
                
            }
            
            RoomContainer portalJoinRoom = room.roomTracker.checkRoomById(childRoomId, out bool instantiated);

            if (instantiated)
            {
                destination = portalJoinRoom.GetComponent<Portal>();
            }
        }

        public override void Disable()
        {
            base.Disable();
        }

        public void Teleport(GameObject item)
        {
            RoomContainer destinationRoom = room.roomTracker.checkRoomById(destination.room.id, out bool instantiated);
            print("Destination Present: "+instantiated);
        }
        public override string ToString()
        {
            return "Portal "+room.id;
        }
    }
}