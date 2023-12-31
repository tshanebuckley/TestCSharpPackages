Add this to BaseObject: https://www.newtonsoft.com/json/help/html/JsonObjectAttributeOptIn.htm

Blazor Dynamic Components: https://www.youtube.com/watch?v=Wcc14aoylME

Dynamic Component Docs: https://learn.microsoft.com/en-us/aspnet/core/blazor/components/dynamiccomponent?view=aspnetcore-7.0

Blazor RenderTree (dom updating): https://www.youtube.com/watch?v=f3W7hg2G-NM

Blazor Winforms: https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/windows-forms?view=aspnetcore-7.0

Entity Framework: https://www.youtube.com/watch?v=DBI59f56L5I

EF Postgres Json: https://www.npgsql.org/efcore/mapping/json.html?tabs=data-annotations%2Cpoco

Blazor TabControl: https://www.youtube.com/watch?v=g5y2TO2KGu8

Data-binding (Blazor University): https://blazor-university.com/components/two-way-binding/

Data-binding updates: https://www.youtube.com/watch?v=i04LddWyYMU

Blazor DataGrid: https://www.youtube.com/watch?v=ryA2r1m5f8M

Blazor DatePicker: https://www.pragimtech.com/blog/blazor/blazor-datepicker/

Blazor TreeView: https://techcommunity.microsoft.com/t5/healthcare-and-life-sciences/creating-a-generic-tree-view-blazor-component/ba-p/3640237

Signals (a js example): https://www.youtube.com/watch?v=bUy4xiJ05KY

Blazor Component Communication: https://www.youtube.com/watch?v=Thwozpi0V58

Json-backed Dynamic Component: https://medium.com/codex/blazor-webassembly-dynamic-creation-of-components-based-on-json-configuration-d1df664e5e19

Blazor AppState: https://www.youtube.com/watch?v=4WPuGwxZKIA

Async events: https://medium.com/@a.lyskawa/the-hitchhiker-guide-to-asynchronous-events-in-c-e9840109fb53

EAP pattern: https://learn.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/event-based-asynchronous-pattern-overview

EAP component example: https://learn.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/9hk12d4y(v=vs.100)

TAP: https://learn.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/task-based-asynchronous-pattern-tap

StateContainer example: https://learn.microsoft.com/en-us/aspnet/core/blazor/state-management?view=aspnetcore-7.0&pivots=webassembly

MVVM examples and "worth it?" for Blazor: https://www.youtube.com/watch?v=M4tgU-V7peI&ab_channel=DevExpress

Idea for dynamically loading nested components: have our interface live where "ComponentDescription" lives in the example json-loaded component and add a slotting mechanism like svelte and web-components. Will need the load for the first component to load the nested components. How to get the json string to begin with? How to pass the appropriate json down the slots? How will to slots know their relative path? What if there are multiple slots? How to handle data binding? Could make events objects and also load them from json like the OnClick altering event in the example. Maybe load the json through updates to AppState?
