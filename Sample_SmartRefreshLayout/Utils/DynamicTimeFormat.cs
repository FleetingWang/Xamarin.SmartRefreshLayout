using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Text;
using Java.Util;
using Java.Lang;

namespace Sample_SmartRefreshLayout.Utils
{
    public class DynamicTimeFormat: SimpleDateFormat
    {
        private static Locale locale = Locale.China;
        private static string[] weeks = { "周日", "周一", "周二", "周三", "周四", "周五", "周六" };
        private static string[] moments = { "中午", "凌晨", "早上", "下午", "晚上" };

        private string mFormat = "%s";

        public DynamicTimeFormat()
            :this("%s", "yyyy年", "M月d日", "HH:mm")
        {
        }

        public DynamicTimeFormat(string format)
        {
            this.mFormat = format;
        }

        public DynamicTimeFormat(string yearFormat, string dateFormat, string timeFormat)
            :base(Java.Lang.String.Format(locale, "%s %s %s", yearFormat, dateFormat, timeFormat), locale)
        {
        }

        public DynamicTimeFormat(string format, string yearFormat, string dateFormat, string timeFormat)
            :this(yearFormat, dateFormat, timeFormat)
        {
            this.mFormat = format;
        }

        public override StringBuffer Format(Date date, StringBuffer toAppendTo, FieldPosition pos)
        {
            toAppendTo = base.Format(date, toAppendTo, pos);

            Calendar otherCalendar = Calendar;
            Calendar todayCalendar = (Calendar)otherCalendar.Class.NewInstance();

            int hour = otherCalendar.Get(CalendarField.HourOfDay);

            string[] times = toAppendTo.ToString().Split(' ');
            string moment = hour == 12 ? moments[0] : moments[hour / 6 + 1];
            string timeFormat = moment + " " + times[2];
            string dateFormat = times[1] + " " + timeFormat;
            string yearFormat = times[0] + dateFormat;
            toAppendTo.Delete(0, toAppendTo.Length());

            bool yearTemp = todayCalendar.Get(CalendarField.Year) == otherCalendar.Get(CalendarField.Year);
            if (yearTemp)
            {
                int todayMonth = todayCalendar.Get(CalendarField.Month);
                int otherMonth = otherCalendar.Get(CalendarField.Month);
                if (todayMonth == otherMonth)
                {//表示是同一个月
                    int temp = todayCalendar.Get(CalendarField.Date) - otherCalendar.Get(CalendarField.Date);
                    switch (temp)
                    {
                        case 0:
                            toAppendTo.Append(timeFormat);
                            break;
                        case 1:
                            toAppendTo.Append("昨天 ");
                            toAppendTo.Append(timeFormat);
                            break;
                        case 2:
                            toAppendTo.Append("前天 ");
                            toAppendTo.Append(timeFormat);
                            break;
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            int dayOfMonth = otherCalendar.Get(CalendarField.WeekOfMonth);
                            int todayOfMonth = todayCalendar.Get(CalendarField.WeekOfMonth);
                            if (dayOfMonth == todayOfMonth)
                            {//表示是同一周
                                int dayOfWeek = otherCalendar.Get(CalendarField.DayOfWeek);
                                if (dayOfWeek != 1)
                                {//判断当前是不是星期日     如想显示为：周日 12:09 可去掉此判断
                                    toAppendTo.Append(weeks[otherCalendar.Get(CalendarField.DayOfWeek) - 1]);
                                    toAppendTo.Append(' ');
                                    toAppendTo.Append(timeFormat);
                                }
                                else
                                {
                                    toAppendTo.Append(dateFormat);
                                }
                            }
                            else
                            {
                                toAppendTo.Append(dateFormat);
                            }
                            break;
                        default:
                            toAppendTo.Append(dateFormat);
                            break;
                    }
                }
                else
                {
                    toAppendTo.Append(dateFormat);
                }
            }
            else
            {
                toAppendTo.Append(yearFormat);
            }

            int length = toAppendTo.Length();
            toAppendTo.Append(Java.Lang.String.Format(locale, mFormat, toAppendTo.ToString()));
            toAppendTo.Delete(0, length);
            return toAppendTo;
        }
    }
}