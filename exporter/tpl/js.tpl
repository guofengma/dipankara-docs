'use strict';

module.exports = {

  {% for row in table %}
  {% if row.Key.def.type == 2 %}'{{ row.Key.value.ivalue }}'{% elsif row.Key.def.type == 4 %}{{ row.Value[i].svalue }}{% endif %}: {
    {% for i in index %}
	{{ row.Value[i].def.name }}: {% if row.Value[i].def.type == 1 %}{{ row.Value[i].value.bvalue }}{% elsif row.Value[i].def.type == 2 %}{{ row.Value[i].value.ivalue }}{% elsif row.Value[i].def.type == 3 %}{{ row.Value[i].value.fvalue }}{% elsif row.Value[i].def.type == 4 %}'{{ row.Value[i].value.svalue }}'{% elsif row.Value[i].def.type == 5 %}{% raw %} { {% endraw %}{% for v in row.Value[i].value.ilvalue %}{{v}},{% endfor %}{% raw %} } {% endraw %}{% elsif row.Value[i].def.type == 6 %}{% raw %} { {% endraw %}{% for v in row.Value[i].value.flvalue %}{{v}},{% endfor %}{% raw %} } {% endraw %}{% elsif row.Value[i].def.type == 7 %}[{% for v in row.Value[i].value.slvalue %}'{{v}}',{% endfor %}]{% elsif row.Value[i].def.type == 8 %}{% raw %} { {% endraw %}{% for v in row.Value[i].value.dictvalue %}{{v}}={% endfor %}{% raw %} } {% endraw %}{% endif %},{% endfor %}
  },
  {% endfor %}
};
