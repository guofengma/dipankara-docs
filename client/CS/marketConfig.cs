using System;
using System.Collections.Generic;
using System.Text;
namespace Configs {
public class marketConfig {
public class marketItem {public long id;
public string name;
public string des;
public long price;
public long marketStock;
public long min;
}
private Dictionary<string, marketItem> _items = new Dictionary<string, marketItem>();
public Dictionary<string, marketItem> Items { get { return _items; } }
public void Load(string xml) {
Dictionary<string, object> dict =  Maria.PlistCS.Plist.readPlist(Encoding.UTF8.GetBytes(xml)) as Dictionary<string, object>;
foreach (var item in dict) {
Dictionary<string, object> row = item.Value as Dictionary<string, object>;
marketItem i = new marketItem();
i.id = Convert.ToInt64(row["id"]);
i.name = Convert.ToString(row["name"]);
i.des = Convert.ToString(row["des"]);
i.price = Convert.ToInt64(row["price"]);
i.marketStock = Convert.ToInt64(row["marketStock"]);
i.min = Convert.ToInt64(row["min"]);

_items.Add(item.Key, i);
}
}
}
}
