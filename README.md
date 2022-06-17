# ROS Windows Form Example

## Requirement

- ROS2 (pre-built binary packages)
- [ros2_dotnet](https://github.com/ros2-dotnet/ros2_dotnet)
- Visual Studio with .NET Desktop Development

## Visual Studio Setup

- Create a new Visual Studio project (Visual C# - Windows Forms App).
- In Solution Explorer panel:

    ```
    right click on References - Add reference...
    ```
    and include `{ros2_ws}\install\lib\rcldotnet\dotnet\rcldotnet_assemblies.dll`, `{ros2_ws}*\install\lib\rcldotnet\dotnet\rcldotnet_common.dll`, and `{ros2_ws}\install\lib\std_msgs\dotnet\std_msgs_assemblies.dll`.


- Now you can include your ROS2 code in scripts, compile your project and run it.

## Run

- Edit file path in `run_example.bat`.
- Run `run_example.bat` as administrator.

## Reference

- [Microsoft IoT: ros2_dotnet](https://github.com/ms-iot/ros2_dotnet)
- [ros2_dotnet](https://github.com/ros2-dotnet/ros2_dotnet)