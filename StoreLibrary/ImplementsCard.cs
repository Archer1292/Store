//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImplementsCard : BaseClass
    {
        
        public ImplementsCard(Implement impl, Storage s, int amount, int aviable=1)
        {
           
        }

        public Dictionary<Guid, ImplementsCard> ImplementsCardDict = new Dictionary<Guid, ImplementsCard>();
        public Guid Implement_id { get;private set; }
        public Guid Storage_id { get;private set; }
        public int Amount { get; set; }
        public int Aviable { get; set; }   
        public Implement Implement
        {
            get { return Implement.ImplementsDict[Implement_id]; }
            set
            {
                if (Implement.ImplementsDict.ContainsKey(Implement_id))
                    Implement_id = value.Id;
            }
        }
        public Storage Storage
        {
            get { return Storage.StorageDict[Storage_id]; }
            set
            {
                if (Storage.StorageDict.ContainsKey(value.Id))
                    Storage_id = value.Id;
            }
        }
        
    }
}