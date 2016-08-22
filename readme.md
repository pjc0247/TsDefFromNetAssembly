```c#
var targetAssembly = Assembly.ReflectionOnlyLoad("my.dll");
var script = TsBuilder.Build(targetAssembly);
```