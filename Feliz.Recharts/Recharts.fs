namespace Feliz.Recharts

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type Recharts =
    static member inline areaChart (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "AreaChart" "recharts", createObj !!properties)
    static member inline lineChart (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "LineChart" "recharts", createObj !!properties)
    static member inline barChart (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "BarChart" "recharts", createObj !!properties)
    static member inline bar (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Bar" "recharts", createObj !!properties)
    static member inline xAxis (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "XAxis" "recharts", createObj !!properties)
    static member inline yAxis (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "YAxis" "recharts", createObj !!properties)
    static member inline zAxis (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "ZAxis" "recharts", createObj !!properties)
    static member inline tooltip (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Tooltip" "recharts", createObj !!properties)
    static member inline legend (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Legend" "recharts", createObj !!properties)
    static member inline area (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Area" "recharts", createObj !!properties)
    static member inline line (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Line" "recharts", createObj !!properties)
    static member inline cartesianGrid (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "CartesianGrid" "recharts", createObj !!properties)
    static member inline responsiveContainer (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "ResponsiveContainer" "recharts", createObj !!properties)
    static member inline composedChart (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "ComposedChart" "recharts", createObj !!properties)
    static member inline referenceLine (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "ReferenceLine" "recharts", createObj !!properties)
    static member inline referenceArea (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "ReferenceArea" "recharts", createObj !!properties)
    static member inline referenceDot (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "ReferenceDot" "recharts", createObj !!properties)
    static member inline pieChart (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "PieChart" "recharts", createObj !!properties)
    static member inline pie (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Pie" "recharts", createObj !!properties)
    static member inline radarChart (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "RadarChart" "recharts", createObj !!properties)
    static member inline radar (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Radar" "recharts", createObj !!properties)
    static member inline radialBarChart (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "RadialBarChart" "recharts", createObj !!properties)
    static member inline radialBar (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "RadialBar" "recharts", createObj !!properties)
    static member inline scatterChart (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "ScatterChart" "recharts", createObj !!properties)
    static member inline scatter (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "Scatter" "recharts", createObj !!properties)
    static member inline polarAngleAxis (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "PolarAngleAxis" "recharts", createObj !!properties)
    static member inline polarGrid (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "PolarGrid" "recharts", createObj !!properties)
    static member inline polarRadiusAxis (properties: IReactProperty list) =
        Interop.reactApi.createElement(import "PolarRadiusAxis" "recharts", createObj !!properties)