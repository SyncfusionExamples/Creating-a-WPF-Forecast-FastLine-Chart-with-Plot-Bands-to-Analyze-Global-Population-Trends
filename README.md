# Creating a WPF Forecast FastLine Chart with PlotBands to Analyze Global Population Trends
This sample shows how to create a [WPF FastLine Chart](https://help.syncfusion.com/wpf/charts/fastchart/fast-series#fast-line) with forecast capabilities and plot bands to analyze global population trends by age group.

**Plot bands** are a useful feature that allows us to highlight specific regions within the chart, aiding in the analysis of population data across different age groups. In this example, we'll be looking at the global population from 1950 to 2100. The population will be categorized into various age groups, and we'll use plot bands to shade key time periods (future trends), making the data easier to interpret.

## Key features of the Syncfusion WPF FastLine chart
The key features of the FastLine chart customization include chart features such as chart header, axis customization, series palette customization, and interaction features.

### Chart Header customization:
In the Syncfusion WPF Chart, [Header](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartBase.html#Syncfusion_UI_Xaml_Charts_ChartBase_Header) property is used to define the chart's title. You can further adjust the alignment of the header using the [HorizontalHeaderAlignment](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartBase.html#Syncfusion_UI_Xaml_Charts_ChartBase_HorizontalHeaderAlignment) property.

### Customizing the Axis
In chart axis, you can customize axis intervals, gridlines, and labels.

### Plotbands:
Syncfusion charts allow you to add [striplines (plotbands)](https://help.syncfusion.com/wpf/charts/striplines) to shade specific regions of the plot area for better data visualization. In the example below, the stripline starts from 2024 and extends with a width of 100 units. The background color of the stripline has been customized to represent the future population trends.

### Customizing the Series Appearance
The Syncfusion WPF FastLine Chart allows you to customize the series' fill colors. Additionally, the Forecast FastLine series can be customized with a dotted line using the [StrokeDashArray](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.FastLineSeries.html#Syncfusion_UI_Xaml_Charts_FastLineSeries_StrokeDashArray) property.
  
### Trackball behavior: 
The [ChartTrackBallBehavior](https://help.syncfusion.com/wpf/charts/interactive-features/trackball) allows tracking of data points closest to the cursor position. The visibility of the trackball label can be controlled using the [ShowTrackballInfo](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.CartesianSeries.html#Syncfusion_UI_Xaml_Charts_CartesianSeries_ShowTrackballInfo) property. Additionally, you can customize the appearance of the trackball label using the [TrackBallLabelTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_TrackBallLabelTemplate) property. 

After executing these code examples, we will get the output that resembles the following image.

![ScreenCapture_9-16-2024 9 44 33 AM](https://github.com/user-attachments/assets/a24eb718-c524-4100-b750-d2679617805a)

## Troubleshooting
Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [WPF Forecast FastLine Chart with PLotBands blog post]().


