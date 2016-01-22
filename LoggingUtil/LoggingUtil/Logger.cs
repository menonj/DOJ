/*
 * Created by SharpDevelop.
 * User: jmenon
 * Date: 9/14/2015
 * Time: 3:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using log4net;
using log4net.Config;

namespace Logger
{
	public class Logger
	{
	    private static readonly ILog logger = 
    	       LogManager.GetLogger(typeof(Logger));
    
    	static Logger()
    	{
        	XmlConfigurator.Configure();
    	}

    	public static void DEBUG(string info)
    	{
    		logger.Debug(info);
    	}

    	public static void INFO(string info)
    	{
    		logger.Info(info);
    	}
    	
    	public static void WARN(string info)
    	{
    		logger.Warn(info);
    	}
    	
    	public static void ERROR(string info)
    	{
    		logger.Error(info);
    	}
    	
    	public static void FATAL(string info)
    	{
    		logger.Fatal(info);
    	}

    	
    	/*static void Main(string[] args)
    	{
    	    logger.Debug("Here is a debug log.");
    	    logger.Info("... and an Info log.");
    	    logger.Warn("... and a warning.");
    	    logger.Error("... and an error.");
    	    logger.Fatal("... and a fatal error.");
    	}*/
	}
}