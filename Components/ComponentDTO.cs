using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Components
{
    class ComponentDto
    {
        public string TypeName { get; set; }
        public Dictionary<string, ParameterValueDto> Parameters
        { get; set; }
    }
    class ParameterValueDto
    {
        public string TypeName { get; set; }
        public object Value { get; set; }
    }
    class ComponentDescription
    {
        public Type ComponentType { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
    }
    static class ComponentDtoToComponent
    {
        public static ComponentDescription ToComponent(
            this ComponentDto dto)
        {
            return new ComponentDescription
            {
                ComponentType = Type.GetType(dto.TypeName),
                Parameters = dto.Parameters?.ToDictionary(
                    pp => pp.Key,
                    pp => pp.Value != null
                        ? JsonSerializer.Deserialize(
                            ((JsonElement)pp.Value.Value).GetRawText(),
                            Type.GetType(pp.Value.TypeName))
                        : null)
                    ?? new Dictionary<string, object>()
            };
        }
    }
}
