using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace CAx_KeyManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Add created key by user into the Keys Table
        public static void CreateInDatabase(Key _key)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Keys.Add(_key);
                _context.SaveChanges();
            }
        }
        // Add created owner into the Owners Table
        public static void CreateInDatabase(Owner _owner)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.Owners.Add(_owner);
                _context.SaveChanges();
            }
        }

        // Reading data from database
        public static void ReadFromDatabase()
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                // First converting the Keys Table to a list then adding it to DataManager.BindingKeyList
                List<Key> _keys = _context.Keys.ToList();
                foreach (Key _key in _keys)
                {
                    DataManager.AddKeyFromDB(_key);
                    Debug.WriteLine($"Key: {_key.UniqueID}");
                }
                // First converting the Owners Table to a list then adding it to DataManager.BindingOwnerList
                List<Owner> _owners = _context.Owners.ToList();

                // Remove duplicated names
                HashSet<Owner> ownerSet = new HashSet<Owner>();
                foreach (Owner ownerElement in _owners)
                {
                    if (!ownerElement.Name)
                }

                foreach (Owner _owner in _owners)
                {
                    DataManager.AddOwnerFromDB(_owner);
                    Debug.WriteLine($"Owner: {_owner.Name}");
                }
            }
        }

        // Updating data in database based on changes made to the DataGrid
        public static void UpdateDatabase(Key _key)
        {
            Debug.WriteLine("Database has been updated!!!!!!");
            using (DatabaseContext _context = new DatabaseContext())
            {
                // First look for the entity in database
                Key _entity = findKeyInDatabase(_key.ID);
                if (_entity != null)
                {
                    // Updating the modified key object
                    _entity.Owner  = _key.Owner;
                    _entity.RoomID = _key.RoomID;

                    // Mark as "changed", so that the changes can be made when saving the database 
                    _context.Entry(_entity).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                }
            }
        }

        // Method to remove key from database
        public static void DeleteFromDatabase(Key _key)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                Key _entity = findKeyInDatabase(_key.ID);
                if (_entity != null)
                {
                    _context.Entry(_entity).State = System.Data.Entity.EntityState.Deleted;
                    _context.Keys.Remove(_entity);
                }
                else
                {
                    MessageBox.Show($"The key with the ID '{_key.ID}' cannot be deleted!");
                }
                _context.SaveChanges();
            }
        }

        // For the given ID, return the corresponding Key
        private static Key findKeyInDatabase(int _id)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                Key _entity = _context.Keys.Find(_id);
                if (_entity == null)
                    MessageBox.Show($"The entity with the '{_id}' cannot be found!");

                return _entity;
            }
        }
    }
}
