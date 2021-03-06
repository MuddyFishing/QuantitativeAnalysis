﻿using Autofac;
using BackTestingPlatform.Strategies.Futures.XiaoLong;
using QuantitativeAnalysis.ApplicationLayer.DataProcessingSystem.OptionTickDataProcessing;
using QuantitativeAnalysis.ServiceLayer.MyCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {

            Platforms.Initialize(); //初始化
            // LocalRunner runner = new LocalRunner();
            // runner.run();
            (new LocalRunner()).run();
            Platforms.ShutDown();   //关闭
            //test();
        }
    }


    class LocalRunner
    {
        public void run()
        {
            //double[,] A = new double[2, 2] { { 3, -1 }, { 1, -3 } };
            //double[] b = new double[2] { 1, 1 };
            //var x = MatrixInverse.getInverse(A, b);
            //readFromDataYes.getData("D:\\BTP\\OtherSource\\kline_dce_i.csv", "kline_dce_i.csv");
            DateTime now = DateTime.Now;
            //var data = Platforms.container.Resolve<FuturesMinuteRepository>().fetchFromLocalCsvOrWindAndSave("RB.SHF", Kit.ToDate(20161001));
            //EfficiencyRatio test = new EfficiencyRatio(20140101, 20161209, "RB.SHF", frequency:5,numbers:6,longLevel:0.75,shortLevel:-0.75);
            //StraddleWithHedge2 test = new StraddleWithHedge2(20150210, 20161206, 20);
            //var paras = new EfficiencyRatioWithParametersChoice(20150101, 20170218, "RB.SHF", 60, 20);
            //var test = new EfficiencyRatioWithSpecifiedParametres(20150101, 20170218, "RB.SHF", paras.parameters);
            var test = new DualThrustTest(20150101, 20170516, "RB.SHF");
            //var test = new OptionTickDataArrangement(20100101,20170629);
            DateTime now2 = DateTime.Now;
            Console.WriteLine(now2 - now);
        }
    }
}
