using System;
using System.Collections.Generic;
using System.Text;
namespace Configs {
public class eventConfig {
public class eventItem {public long id;
public string name;
public string desc;
public long goodsId;
public long max;
public long min;
}
private Dictionary<string, eventItem> _items = new Dictionary<string, eventItem>();
public Dictionary<string, eventItem> Items { get { return _items; } }
public void Load(string xml) {
Dictionary<string, object> dict =  Maria.PlistCS.Plist.readPlist(Encoding.UTF8.GetBytes(xml)) as Dictionary<string, object>;
foreach (var item in dict) {
Dictionary<string, object> row = item.Value as Dictionary<string, object>;
eventItem i = new eventItem();
i.id = Convert.ToInt64(row["id"]);
i.name = Convert.ToString(row["name"]);
i.desc = Convert.ToString(row["desc"]);
i.goodsId = Convert.ToInt64(row["goodsId"]);
i.max = Convert.ToInt64(row["max"]);
i.min = Convert.ToInt64(row["min"]);

_items.Add(item.Key, i);
}
}
}
}
