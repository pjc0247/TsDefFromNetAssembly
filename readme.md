```c#
var targetAssembly = Assembly.ReflectionOnlyLoad("my.dll");
var script = TsBuilder.Build(targetAssembly);
```

```ts
// System.String
interface StringImpl {
    Join(separator: string, value: string[]): string;
    Join(separator: string, values: any[]): string;
    Join(separator: string, values: any): string;
    Join(separator: string, values: any): string;
    Join(separator: string, value: string[], startIndex: number, count: number): string;
    Equals(a: string, b: string): boolean;
    Equals(a: string, b: string, comparisonType: any): boolean;
    op_Equality(a: string, b: string): boolean;
    op_Inequality(a: string, b: string): boolean;
    IsNullOrEmpty(value: string): boolean;
    IsNullOrWhiteSpace(value: string): boolean;
    Compare(strA: string, strB: string): number;
    Compare(strA: string, strB: string, ignoreCase: boolean): number;
    Compare(strA: string, strB: string, comparisonType: any): number;
    Compare(strA: string, strB: string, culture: any, options: any): number;
    Compare(strA: string, strB: string, ignoreCase: boolean, culture: any): number;
    Compare(strA: string, indexA: number, strB: string, indexB: number, length: number): number;
    Compare(strA: string, indexA: number, strB: string, indexB: number, length: number, ignoreCase: boolean): number;
    Compare(strA: string, indexA: number, strB: string, indexB: number, length: number, ignoreCase: boolean, culture: any): number;
    Compare(strA: string, indexA: number, strB: string, indexB: number, length: number, culture: any, options: any): number;
    Compare(strA: string, indexA: number, strB: string, indexB: number, length: number, comparisonType: any): number;
    CompareOrdinal(strA: string, strB: string): number;
    CompareOrdinal(strA: string, indexA: number, strB: string, indexB: number, length: number): number;
    Format(format: string, arg0: any): string;
    Format(format: string, arg0: any, arg1: any): string;
    Format(format: string, arg0: any, arg1: any, arg2: any): string;
    Format(format: string, args: any[]): string;
    Format(provider: any, format: string, arg0: any): string;
    Format(provider: any, format: string, arg0: any, arg1: any): string;
    Format(provider: any, format: string, arg0: any, arg1: any, arg2: any): string;
    Format(provider: any, format: string, args: any[]): string;
    Copy(str: string): string;
    Concat(arg0: any): string;
    Concat(arg0: any, arg1: any): string;
    Concat(arg0: any, arg1: any, arg2: any): string;
    Concat(arg0: any, arg1: any, arg2: any, arg3: any): string;
    Concat(args: any[]): string;
    Concat(values: any): string;
    Concat(values: any): string;
    Concat(str0: string, str1: string): string;
    Concat(str0: string, str1: string, str2: string): string;
    Concat(str0: string, str1: string, str2: string, str3: string): string;
    Concat(values: string[]): string;
    Intern(str: string): string;
    IsInterned(str: string): string;
}
declare var String: StringImpl;
```
