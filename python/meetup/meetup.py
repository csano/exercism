import calendar


class MeetupDayException(Exception):
    pass


def get_weekday_value_for_day_of_week(day_str):
    return {
        'Monday': 0,
        'Tuesday': 1,
        'Wednesday': 2,
        'Thursday': 3,
        'Friday': 4,
        'Saturday': 5,
        'Sunday': 6,
    }[day_str]


def get_dates_of_all_days_of_the_week_in_month(day_of_week, month, year):
    day_value = get_weekday_value_for_day_of_week(day_of_week)
    weeks_in_month = calendar.Calendar().monthdatescalendar(year, month)
    return [week[day_value] for week in weeks_in_month if week[day_value].month == month]


def meetup_day(year, month, day_of_week, word):
    day_dates = get_dates_of_all_days_of_the_week_in_month(day_of_week, month, year)

    if word == 'teenth':
        return [date for date in day_dates if date.day in range(13, 19)][0]
    if word == 'last':
        return day_dates[len(day_dates) - 1]
    if word[0].isdigit():
        index = int(word[0]) - 1
        if index < len(day_dates):
            return day_dates[index]

    raise MeetupDayException()