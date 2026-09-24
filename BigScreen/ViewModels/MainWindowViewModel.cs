using BigScreen.Commons;
using DryIoc;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace BigScreen.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Geometry));
            Geometry data0 = (Geometry)(converter.ConvertFrom("M512 0C229.2352 0 0 229.2352 0 512s229.2352 512 512 512 512-229.2352 512-512S794.7648 0 512 0zM304.9216 275.2896c48.2304 0 87.3344 38.6688 87.3344 86.3872 0 47.7056-39.104 86.3872-87.3344 86.3872-48.2304 0-87.3216-38.6816-87.3216-86.3872C217.6 313.9584 256.704 275.2896 304.9216 275.2896zM683.3536 793.6c0 21.2096-17.1904 38.4-38.4 38.4L294.8096 832c-21.2096 0-38.4-17.1904-38.4-38.4l0-38.3872c0-21.2096 17.1904-38.4 38.4-38.4l97.4464 0L237.0048 457.664c0 0 26.2656 23.0912 48.5248 28.8 22.2464 5.696 63.9744 7.2832 106.7264-38.4l155.2512 268.7616 97.4464 0c21.2096 0 38.4 17.1904 38.4 38.4L683.3536 793.6zM810.7008 417.4976l-111.7312 75.2768c-8.8064 5.9392-20.8256 3.6736-26.816-5.056-2.6624-3.8656-3.4432-8.3456-2.9952-12.672l-44.1984-51.6992c-4.352 3.4176-9.7536 5.5296-15.7184 5.5296l-36.1216 0c-14.144 0-25.6-11.4688-25.6-25.6l0 6.4-126.144 0 0-1.024c5.9904-12.1088 9.7024-28.6848 9.7024-46.976 0-18.304-3.712-34.8672-9.7024-46.976l0-1.0112 126.144 0 0 6.4c0-14.1312 11.456-25.6 25.6-25.6l34.7392 0 58.688-68.5824c-0.448-4.3392 0.3328-8.832 3.008-12.7232 6.0288-8.768 18.0992-11.0336 26.9568-5.0688l112.32 75.584c8.8576 5.9648 11.1616 17.9072 5.12 26.6624-6.0288 8.768-18.0992 11.0336-26.9568 5.0688l-92.7872-62.4384-59.3792 69.3888 0 53.3504 61.8368 72.3328 92.3008-62.1824c8.8064-5.9392 20.8128-3.6864 26.816 5.056S819.5072 411.5584 810.7008 417.4976zM304.9216 419.264c32.1536 0 58.2272-25.7792 58.2272-57.5872s-26.0736-57.6-58.2272-57.6c-32.1536 0-58.2144 25.792-58.2144 57.6S272.7808 419.264 304.9216 419.264zM304.9216 332.8768c16.0768 0 29.1072 12.8896 29.1072 28.8 0 15.8976-13.0304 28.8-29.1072 28.8-16.0768 0-29.1072-12.8896-29.1072-28.8C275.8144 345.7664 288.8448 332.8768 304.9216 332.8768z"));
            Geometry data1 = (Geometry)(converter.ConvertFrom("M512 0C229.2352 0 0 229.2352 0 512s229.2352 512 512 512 512-229.2352 512-512S794.7648 0 512 0zM304.9216 275.2896c48.2304 0 87.3344 38.6688 87.3344 86.3872 0 47.7056-39.104 86.3872-87.3344 86.3872-48.2304 0-87.3216-38.6816-87.3216-86.3872C217.6 313.9584 256.704 275.2896 304.9216 275.2896zM683.3536 793.6c0 21.2096-17.1904 38.4-38.4 38.4L294.8096 832c-21.2096 0-38.4-17.1904-38.4-38.4l0-38.3872c0-21.2096 17.1904-38.4 38.4-38.4l97.4464 0L237.0048 457.664c0 0 26.2656 23.0912 48.5248 28.8 22.2464 5.696 63.9744 7.2832 106.7264-38.4l155.2512 268.7616 97.4464 0c21.2096 0 38.4 17.1904 38.4 38.4L683.3536 793.6zM810.7008 417.4976l-111.7312 75.2768c-8.8064 5.9392-20.8256 3.6736-26.816-5.056-2.6624-3.8656-3.4432-8.3456-2.9952-12.672l-44.1984-51.6992c-4.352 3.4176-9.7536 5.5296-15.7184 5.5296l-36.1216 0c-14.144 0-25.6-11.4688-25.6-25.6l0 6.4-126.144 0 0-1.024c5.9904-12.1088 9.7024-28.6848 9.7024-46.976 0-18.304-3.712-34.8672-9.7024-46.976l0-1.0112 126.144 0 0 6.4c0-14.1312 11.456-25.6 25.6-25.6l34.7392 0 58.688-68.5824c-0.448-4.3392 0.3328-8.832 3.008-12.7232 6.0288-8.768 18.0992-11.0336 26.9568-5.0688l112.32 75.584c8.8576 5.9648 11.1616 17.9072 5.12 26.6624-6.0288 8.768-18.0992 11.0336-26.9568 5.0688l-92.7872-62.4384-59.3792 69.3888 0 53.3504 61.8368 72.3328 92.3008-62.1824c8.8064-5.9392 20.8128-3.6864 26.816 5.056S819.5072 411.5584 810.7008 417.4976zM304.9216 419.264c32.1536 0 58.2272-25.7792 58.2272-57.5872s-26.0736-57.6-58.2272-57.6c-32.1536 0-58.2144 25.792-58.2144 57.6S272.7808 419.264 304.9216 419.264zM304.9216 332.8768c16.0768 0 29.1072 12.8896 29.1072 28.8 0 15.8976-13.0304 28.8-29.1072 28.8-16.0768 0-29.1072-12.8896-29.1072-28.8C275.8144 345.7664 288.8448 332.8768 304.9216 332.8768z"));
            Geometry data2 = (Geometry)(converter.ConvertFrom("M512 0C229.2352 0 0 229.2352 0 512s229.2352 512 512 512 512-229.2352 512-512S794.7648 0 512 0zM304.9216 275.2896c48.2304 0 87.3344 38.6688 87.3344 86.3872 0 47.7056-39.104 86.3872-87.3344 86.3872-48.2304 0-87.3216-38.6816-87.3216-86.3872C217.6 313.9584 256.704 275.2896 304.9216 275.2896zM683.3536 793.6c0 21.2096-17.1904 38.4-38.4 38.4L294.8096 832c-21.2096 0-38.4-17.1904-38.4-38.4l0-38.3872c0-21.2096 17.1904-38.4 38.4-38.4l97.4464 0L237.0048 457.664c0 0 26.2656 23.0912 48.5248 28.8 22.2464 5.696 63.9744 7.2832 106.7264-38.4l155.2512 268.7616 97.4464 0c21.2096 0 38.4 17.1904 38.4 38.4L683.3536 793.6zM810.7008 417.4976l-111.7312 75.2768c-8.8064 5.9392-20.8256 3.6736-26.816-5.056-2.6624-3.8656-3.4432-8.3456-2.9952-12.672l-44.1984-51.6992c-4.352 3.4176-9.7536 5.5296-15.7184 5.5296l-36.1216 0c-14.144 0-25.6-11.4688-25.6-25.6l0 6.4-126.144 0 0-1.024c5.9904-12.1088 9.7024-28.6848 9.7024-46.976 0-18.304-3.712-34.8672-9.7024-46.976l0-1.0112 126.144 0 0 6.4c0-14.1312 11.456-25.6 25.6-25.6l34.7392 0 58.688-68.5824c-0.448-4.3392 0.3328-8.832 3.008-12.7232 6.0288-8.768 18.0992-11.0336 26.9568-5.0688l112.32 75.584c8.8576 5.9648 11.1616 17.9072 5.12 26.6624-6.0288 8.768-18.0992 11.0336-26.9568 5.0688l-92.7872-62.4384-59.3792 69.3888 0 53.3504 61.8368 72.3328 92.3008-62.1824c8.8064-5.9392 20.8128-3.6864 26.816 5.056S819.5072 411.5584 810.7008 417.4976zM304.9216 419.264c32.1536 0 58.2272-25.7792 58.2272-57.5872s-26.0736-57.6-58.2272-57.6c-32.1536 0-58.2144 25.792-58.2144 57.6S272.7808 419.264 304.9216 419.264zM304.9216 332.8768c16.0768 0 29.1072 12.8896 29.1072 28.8 0 15.8976-13.0304 28.8-29.1072 28.8-16.0768 0-29.1072-12.8896-29.1072-28.8C275.8144 345.7664 288.8448 332.8768 304.9216 332.8768z"));
            Geometry data3 = (Geometry)(converter.ConvertFrom("M512 0C229.2352 0 0 229.2352 0 512s229.2352 512 512 512 512-229.2352 512-512S794.7648 0 512 0zM304.9216 275.2896c48.2304 0 87.3344 38.6688 87.3344 86.3872 0 47.7056-39.104 86.3872-87.3344 86.3872-48.2304 0-87.3216-38.6816-87.3216-86.3872C217.6 313.9584 256.704 275.2896 304.9216 275.2896zM683.3536 793.6c0 21.2096-17.1904 38.4-38.4 38.4L294.8096 832c-21.2096 0-38.4-17.1904-38.4-38.4l0-38.3872c0-21.2096 17.1904-38.4 38.4-38.4l97.4464 0L237.0048 457.664c0 0 26.2656 23.0912 48.5248 28.8 22.2464 5.696 63.9744 7.2832 106.7264-38.4l155.2512 268.7616 97.4464 0c21.2096 0 38.4 17.1904 38.4 38.4L683.3536 793.6zM810.7008 417.4976l-111.7312 75.2768c-8.8064 5.9392-20.8256 3.6736-26.816-5.056-2.6624-3.8656-3.4432-8.3456-2.9952-12.672l-44.1984-51.6992c-4.352 3.4176-9.7536 5.5296-15.7184 5.5296l-36.1216 0c-14.144 0-25.6-11.4688-25.6-25.6l0 6.4-126.144 0 0-1.024c5.9904-12.1088 9.7024-28.6848 9.7024-46.976 0-18.304-3.712-34.8672-9.7024-46.976l0-1.0112 126.144 0 0 6.4c0-14.1312 11.456-25.6 25.6-25.6l34.7392 0 58.688-68.5824c-0.448-4.3392 0.3328-8.832 3.008-12.7232 6.0288-8.768 18.0992-11.0336 26.9568-5.0688l112.32 75.584c8.8576 5.9648 11.1616 17.9072 5.12 26.6624-6.0288 8.768-18.0992 11.0336-26.9568 5.0688l-92.7872-62.4384-59.3792 69.3888 0 53.3504 61.8368 72.3328 92.3008-62.1824c8.8064-5.9392 20.8128-3.6864 26.816 5.056S819.5072 411.5584 810.7008 417.4976zM304.9216 419.264c32.1536 0 58.2272-25.7792 58.2272-57.5872s-26.0736-57.6-58.2272-57.6c-32.1536 0-58.2144 25.792-58.2144 57.6S272.7808 419.264 304.9216 419.264zM304.9216 332.8768c16.0768 0 29.1072 12.8896 29.1072 28.8 0 15.8976-13.0304 28.8-29.1072 28.8-16.0768 0-29.1072-12.8896-29.1072-28.8C275.8144 345.7664 288.8448 332.8768 304.9216 332.8768z"));
            Geometry data4 = (Geometry)(converter.ConvertFrom("M512 0C229.2352 0 0 229.2352 0 512s229.2352 512 512 512 512-229.2352 512-512S794.7648 0 512 0zM304.9216 275.2896c48.2304 0 87.3344 38.6688 87.3344 86.3872 0 47.7056-39.104 86.3872-87.3344 86.3872-48.2304 0-87.3216-38.6816-87.3216-86.3872C217.6 313.9584 256.704 275.2896 304.9216 275.2896zM683.3536 793.6c0 21.2096-17.1904 38.4-38.4 38.4L294.8096 832c-21.2096 0-38.4-17.1904-38.4-38.4l0-38.3872c0-21.2096 17.1904-38.4 38.4-38.4l97.4464 0L237.0048 457.664c0 0 26.2656 23.0912 48.5248 28.8 22.2464 5.696 63.9744 7.2832 106.7264-38.4l155.2512 268.7616 97.4464 0c21.2096 0 38.4 17.1904 38.4 38.4L683.3536 793.6zM810.7008 417.4976l-111.7312 75.2768c-8.8064 5.9392-20.8256 3.6736-26.816-5.056-2.6624-3.8656-3.4432-8.3456-2.9952-12.672l-44.1984-51.6992c-4.352 3.4176-9.7536 5.5296-15.7184 5.5296l-36.1216 0c-14.144 0-25.6-11.4688-25.6-25.6l0 6.4-126.144 0 0-1.024c5.9904-12.1088 9.7024-28.6848 9.7024-46.976 0-18.304-3.712-34.8672-9.7024-46.976l0-1.0112 126.144 0 0 6.4c0-14.1312 11.456-25.6 25.6-25.6l34.7392 0 58.688-68.5824c-0.448-4.3392 0.3328-8.832 3.008-12.7232 6.0288-8.768 18.0992-11.0336 26.9568-5.0688l112.32 75.584c8.8576 5.9648 11.1616 17.9072 5.12 26.6624-6.0288 8.768-18.0992 11.0336-26.9568 5.0688l-92.7872-62.4384-59.3792 69.3888 0 53.3504 61.8368 72.3328 92.3008-62.1824c8.8064-5.9392 20.8128-3.6864 26.816 5.056S819.5072 411.5584 810.7008 417.4976zM304.9216 419.264c32.1536 0 58.2272-25.7792 58.2272-57.5872s-26.0736-57.6-58.2272-57.6c-32.1536 0-58.2144 25.792-58.2144 57.6S272.7808 419.264 304.9216 419.264zM304.9216 332.8768c16.0768 0 29.1072 12.8896 29.1072 28.8 0 15.8976-13.0304 28.8-29.1072 28.8-16.0768 0-29.1072-12.8896-29.1072-28.8C275.8144 345.7664 288.8448 332.8768 304.9216 332.8768z"));

            Tabs = new List<Item>() {
                new Item(){
                    Index=0,
                    Content="加工中心",
                    IsChecked=true,
                    Data=data0,
                    CurrentImage="/Resources/Images/d_1.png",
                    DeviceList = new List<DeviceItemModel>()
                    {
                        new DeviceItemModel()
                        {
                            Index=11,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="AUTO",
                                },
                                new VariableModel{
                                    Name="进给倍率",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="主轴转速",
                                    Value="0",
                                    Unit="r/min"
                                },
                                new VariableModel{
                                    Name="机床坐标-X",
                                    Value="-500.000",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="机床坐标-Y",
                                    Value="-122.002",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="机床坐标-Z",
                                    Value="-1525.321",
                                    Unit="mm"
                                },
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=12,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="AUTO",
                                },
                                new VariableModel{
                                    Name="进给倍率",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="主轴转速",
                                    Value="0",
                                    Unit="r/min"
                                },
                                new VariableModel{
                                    Name="机床坐标-X",
                                    Value="-500.000",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="机床坐标-Y",
                                    Value="-122.002",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="机床坐标-Z",
                                    Value="-1525.321",
                                    Unit="mm"
                                },
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=13,
                            IsWarning=true,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="AUTO",
                                },
                                new VariableModel{
                                    Name="进给倍率",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="主轴转速",
                                    Value="0",
                                    Unit="r/min"
                                },
                                new VariableModel{
                                    Name="机床坐标-X",
                                    Value="-500.000",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="机床坐标-Y",
                                    Value="-122.002",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="机床坐标-Z",
                                    Value="-1525.321",
                                    Unit="mm"
                                },
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=14,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="AUTO",
                                },
                                new VariableModel{
                                    Name="进给倍率",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="主轴转速",
                                    Value="0",
                                    Unit="r/min"
                                },
                                new VariableModel{
                                    Name="机床坐标-X",
                                    Value="-500.000",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="机床坐标-Y",
                                    Value="-122.002",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="机床坐标-Z",
                                    Value="-1525.321",
                                    Unit="mm"
                                },
                            }
                        }
                    }
                },
                new Item(){
                    Index=1,
                    Content="电火花",
                    IsChecked=false,
                    Data=data1,
                    CurrentImage="/BigScreen;component/Resources/Images/d_2.png",
                    DeviceList = new List<DeviceItemModel>()
                    {
                        new DeviceItemModel()
                        {
                            Index=21,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="L编号",
                                    Value="31",
                                },
                                new VariableModel{
                                    Name="N编号",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="B编号",
                                    Value="0"
                                },
                                new VariableModel{
                                    Name="启动ON时间",
                                    Value="0:0:10"
                                },
                                new VariableModel{
                                    Name="加工ON时间",
                                    Value="0:0:10"
                                },
                                new VariableModel{
                                    Name="E条件编号",
                                    Value="909002"
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=22,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="L编号",
                                    Value="31",
                                },
                                new VariableModel{
                                    Name="N编号",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="B编号",
                                    Value="0"
                                },
                                new VariableModel{
                                    Name="启动ON时间",
                                    Value="0:0:10"
                                },
                                new VariableModel{
                                    Name="加工ON时间",
                                    Value="0:0:10"
                                },
                                new VariableModel{
                                    Name="E条件编号",
                                    Value="909002"
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=23,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="L编号",
                                    Value="31",
                                },
                                new VariableModel{
                                    Name="N编号",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="B编号",
                                    Value="0"
                                },
                                new VariableModel{
                                    Name="启动ON时间",
                                    Value="0:0:10"
                                },
                                new VariableModel{
                                    Name="加工ON时间",
                                    Value="0:0:10"
                                },
                                new VariableModel{
                                    Name="E条件编号",
                                    Value="909002"
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=24,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="L编号",
                                    Value="31",
                                },
                                new VariableModel{
                                    Name="N编号",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="B编号",
                                    Value="0"
                                },
                                new VariableModel{
                                    Name="启动ON时间",
                                    Value="0:0:10"
                                },
                                new VariableModel{
                                    Name="加工ON时间",
                                    Value="0:0:10"
                                },
                                new VariableModel{
                                    Name="E条件编号",
                                    Value="909002"
                                }
                            }
                        }
                    }
                },
                new Item(){
                    Index=2,
                    Content="机械臂",
                    IsChecked=false,
                    Data=data2,
                    CurrentImage="/BigScreen;component/Resources/Images/d_3.png",
                    DeviceList = new List<DeviceItemModel>()
                    {
                        new DeviceItemModel()
                        {
                            Index=31,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="MANUAL",
                                },
                                new VariableModel{
                                    Name="关节轴-J1",
                                    Value="-97.979",
                                },
                                new VariableModel{
                                    Name="关节轴-J2",
                                    Value="-31.493",
                                },
                                new VariableModel{
                                    Name="关节轴-J3",
                                    Value="-34.517",
                                },
                                new VariableModel{
                                    Name="关节轴-J4",
                                    Value="-0.032",
                                },
                                new VariableModel{
                                    Name="关节轴-J5",
                                    Value="-8.535",
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=32,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="手动",
                                },
                                new VariableModel{
                                    Name="关节轴-J1",
                                    Value="-97.979",
                                },
                                new VariableModel{
                                    Name="关节轴-J2",
                                    Value="-31.493",
                                },
                                new VariableModel{
                                    Name="关节轴-J3",
                                    Value="-34.517",
                                },
                                new VariableModel{
                                    Name="关节轴-J4",
                                    Value="-0.032",
                                },
                                new VariableModel{
                                    Name="关节轴-J5",
                                    Value="-8.535",
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=33,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="手动",
                                },
                                new VariableModel{
                                    Name="关节轴-J1",
                                    Value="-97.979",
                                },
                                new VariableModel{
                                    Name="关节轴-J2",
                                    Value="-31.493",
                                },
                                new VariableModel{
                                    Name="关节轴-J3",
                                    Value="-34.517",
                                },
                                new VariableModel{
                                    Name="关节轴-J4",
                                    Value="-0.032",
                                },
                                new VariableModel{
                                    Name="关节轴-J5",
                                    Value="-8.535",
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=34,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="手动",
                                },
                                new VariableModel{
                                    Name="关节轴-J1",
                                    Value="-97.979",
                                },
                                new VariableModel{
                                    Name="关节轴-J2",
                                    Value="-31.493",
                                },
                                new VariableModel{
                                    Name="关节轴-J3",
                                    Value="-34.517",
                                },
                                new VariableModel{
                                    Name="关节轴-J4",
                                    Value="-0.032",
                                },
                                new VariableModel{
                                    Name="关节轴-J5",
                                    Value="-8.535",
                                }
                            }
                        }
                    }

                },
                new Item(){
                    Index=3,
                    Content="三坐标",
                    IsChecked=false,
                    Data=data3,
                    CurrentImage="/BigScreen;component/Resources/Images/d_4.png",
                    DeviceList = new List<DeviceItemModel>()
                    {
                        new DeviceItemModel()
                        {
                            Index=41,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="MANUAL",
                                },
                                new VariableModel{
                                    Name="位置坐标-X",
                                    Value="50.23",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="位置坐标-Y",
                                    Value="26.67",
                                },
                                new VariableModel{
                                    Name="位置坐标-Z",
                                    Value="10.45",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="表面粗糙度",
                                    Value="0.32",
                                    Unit="μm"
                                },
                                new VariableModel{
                                    Name="峰谷高度",
                                    Value="2.10",
                                    Unit="μm"
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=42,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="MANUAL",
                                },
                                new VariableModel{
                                    Name="位置坐标-X",
                                    Value="50.23",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="位置坐标-Y",
                                    Value="26.67",
                                },
                                new VariableModel{
                                    Name="位置坐标-Z",
                                    Value="10.45",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="表面粗糙度",
                                    Value="0.32",
                                    Unit="μm"
                                },
                                new VariableModel{
                                    Name="峰谷高度",
                                    Value="2.10",
                                    Unit="μm"
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=43,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="MANUAL",
                                },
                                new VariableModel{
                                    Name="位置坐标-X",
                                    Value="50.23",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="位置坐标-Y",
                                    Value="26.67",
                                },
                                new VariableModel{
                                    Name="位置坐标-Z",
                                    Value="10.45",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="表面粗糙度",
                                    Value="0.32",
                                    Unit="μm"
                                },
                                new VariableModel{
                                    Name="峰谷高度",
                                    Value="2.10",
                                    Unit="μm"
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=44,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="MANUAL",
                                },
                                new VariableModel{
                                    Name="位置坐标-X",
                                    Value="50.23",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="位置坐标-Y",
                                    Value="26.67",
                                },
                                new VariableModel{
                                    Name="位置坐标-Z",
                                    Value="10.45",
                                    Unit="mm"
                                },
                                new VariableModel{
                                    Name="表面粗糙度",
                                    Value="0.32",
                                    Unit="μm"
                                },
                                new VariableModel{
                                    Name="峰谷高度",
                                    Value="2.10",
                                    Unit="μm"
                                }
                            }
                        }
                    }

                },
                new Item(){
                    Index=4,
                    Content="线切割",
                    IsChecked=false,
                    Data=data4,
                    CurrentImage="/BigScreen;component/Resources/Images/d_5.png",
                    DeviceList = new List<DeviceItemModel>()
                    {
                        new DeviceItemModel()
                        {
                            Index=51,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="AUTO",
                                },
                                new VariableModel{
                                    Name="停止编号",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="开机ON时间",
                                    Value="0:0:0",
                                },
                                new VariableModel{
                                    Name="作业ON时间",
                                    Value="0:0:0",
                                },
                                new VariableModel{
                                    Name="E条件编号",
                                    Value="909002",
                                },
                                new VariableModel{
                                    Name="机械坐标",
                                    Value="暂无",
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=52,
                            IsWarning=true,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="AUTO",
                                },
                                new VariableModel{
                                    Name="停止编号",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="开机ON时间",
                                    Value="0:0:0",
                                },
                                new VariableModel{
                                    Name="作业ON时间",
                                    Value="0:0:0",
                                },
                                new VariableModel{
                                    Name="E条件编号",
                                    Value="909002",
                                },
                                new VariableModel{
                                    Name="机械坐标",
                                    Value="暂无",
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=53,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="AUTO",
                                },
                                new VariableModel{
                                    Name="停止编号",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="开机ON时间",
                                    Value="0:0:0",
                                },
                                new VariableModel{
                                    Name="作业ON时间",
                                    Value="0:0:0",
                                },
                                new VariableModel{
                                    Name="E条件编号",
                                    Value="909002",
                                },
                                new VariableModel{
                                    Name="机械坐标",
                                    Value="暂无",
                                }
                            }
                        },
                        new DeviceItemModel()
                        {
                            Index=54,
                            // 设备中有多少监测变量
                            VariableList=new List<VariableModel>{
                                new VariableModel{
                                    Name="工作模式",
                                    Value="AUTO",
                                },
                                new VariableModel{
                                    Name="停止编号",
                                    Value="0",
                                },
                                new VariableModel{
                                    Name="开机ON时间",
                                    Value="0:0:0",
                                },
                                new VariableModel{
                                    Name="作业ON时间",
                                    Value="0:0:0",
                                },
                                new VariableModel{
                                    Name="E条件编号",
                                    Value="909002",
                                },
                                new VariableModel{
                                    Name="机械坐标",
                                    Value="暂无",
                                }
                            }
                        }
                    }

                },
            };

            SelectedItem = Tabs[0];

            for (int i = 0; i < 15; i++)
            {
                AlarmList.Add(new AlarmItemModel() { Index = i + 1 });
            }

            // 启动监听设备信息
            StartMonitor();
        }

        private List<Item> tabs;
        // Tabs这个变化支持通知怎么理解？是Tabs这个整体，发生变化才通知，如： Tabs = new List<Item>() { };
        public List<Item> Tabs
        {
            get { return tabs; }
            set { SetProperty(ref tabs, value); }
        }

        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set { SetProperty(ref selectedItem, value); }
        }

        private List<AlarmItemModel> alarmList = new List<AlarmItemModel>();
        public List<AlarmItemModel> AlarmList
        {
            get { return alarmList; }
            set { SetProperty(ref alarmList, value); }
        }


        public DelegateCommand CloseCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    App.Current.Shutdown();
                });
            }
        }

        public DelegateCommand<object> NavCommand
        {
            get
            {
                return new DelegateCommand<object>((index) =>
                {
                    int i = Convert.ToInt32(index);
                    // 此处是修改的Tabs吗？不是修改Tabs这个整体，是修改了Tabs中的一个项Item中的IsChecked属性
                    Tabs.ForEach(t => t.IsChecked = t.Index == i);
                    SelectedItem = Tabs[i];
                });
            }
        }

        CancellationTokenSource cts = null;
        private void StartMonitor()
        {
            cts = new CancellationTokenSource();
            Task.Run(async () =>
            {
                S7.Net.Plc plc = new S7.Net.Plc(S7.Net.CpuType.S7200Smart, "192.168.2.1", 0, 0);
                plc.Open();

                var list = Tabs[0].DeviceList;
                while (!cts.IsCancellationRequested)
                {
                    ushort[] values = (ushort[])plc.Read(S7.Net.DataType.DataBlock, 1, 100, S7.Net.VarType.Word, 24);
                    // 0 0 0 0 0 0    0 0 0 0 0 0
                    // 报警条件：
                    for (int i = 0; i < 4; i++)
                    {
                        var item = list[i];
                        item.IsWarning = false;

                        for (int j = 0; j < item.VariableList.Count; j++)
                        {
                            item.VariableList[j].Value = values[i * 6 + j].ToString();
                        }

                        // 判断当前设备的主轴转速不能低于50
                        if (Convert.ToUInt16(item.VariableList[2].Value) < 50) item.IsWarning = true;
                    }

                    await Task.Delay(1000);
                }

                plc.Close();
            }, cts.Token);
        }



    }
}
