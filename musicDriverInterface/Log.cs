﻿using System;
using System.Collections.Generic;
using System.Text;

namespace musicDriverInterface
{
    public static class Log
    {
        public static Action<LogLevel, string> writeLine = null;
        public static Action<LogLevel, string> write = null;
        public static LogLevel level = LogLevel.INFO;
        public static int off = (int)LogLevel.WARNING;
        public static Action<string> writeMethod;
        public static Action<string> writeNonReturnMethod;

        public static void WriteLine(LogLevel level, string msg)
        {
            //if ((off & (int)level) != 0) return;

            if (level <= Log.level)
            {
                if (writeMethod != null)
                    writeMethod(String.Format("[{0,-7}] {1}", level, msg));
                else
                    writeLine?.Invoke(level, msg);
            }
        }

        public static void WriteLine(LogLevel level, string msg, params object[] op)
        {
            //if ((off & (int)level) != 0) return;

            if (level <= Log.level)
            {
                msg = string.Format(msg, op);
                if (writeMethod != null)
                    writeMethod(String.Format("[{0,-7}] {1}", level, msg));
                else
                    writeLine?.Invoke(level, msg);
            }
        }

        public static void Write(LogLevel level, string msg)
        {
            //if ((off & (int)level) != 0) return;

            if (level <= Log.level)
            {
                if (writeNonReturnMethod != null)
                    writeNonReturnMethod(String.Format("[{0,-7}] {1}", level, msg));
                else
                    write?.Invoke(level, msg);
            }
        }

        public static void Write(LogLevel level, string msg, params object[] op)
        {
            //if ((off & (int)level) != 0) return;

            if (level <= Log.level)
            {
                msg = string.Format(msg, op);
                if (writeNonReturnMethod != null)
                    writeNonReturnMethod(String.Format("[{0,-7}] {1}", level, msg));
                else
                    write?.Invoke(level, msg);
            }
        }

    }
}
