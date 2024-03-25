using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor;
using UnityEngine;

public class DiskScript : MonoBehaviour
{
    class Disk
    {
        public float x;
        public float y;
        public float radius;

        public Disk[] disk;

        private Disk[] poissonDisk(Disk initial)
        {
            ActiveList active = new ActiveList();
            PlacedDisks placed = new PlacedDisks();

            active.add(initial);
            placed.add(initial);

            //use the same radius throughout
            radius = initial.radius;

            while(!active.isEmpty())
            {
                //IDK
            }

            return disk;
        }

        class ActiveList
        {
            List<Disk> diskStuff = new List<Disk>();
            public void add(Disk n)
            {
                diskStuff.Add(n);
            }
            public void remove(Disk n)
            {
                diskStuff.Remove(n);
            }
            public bool isEmpty()
            {
                return true;
            }
            public void getNext() { }
        }

        class PlacedDisks
        {
            public void add(Disk disk) { }
            public void empty(Disk disk) { }

            //public Disk[] all() 
            //{
            //    return 
            //}

        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}