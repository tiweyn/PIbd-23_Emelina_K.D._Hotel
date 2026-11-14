using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using ProjectHotel.Forms;
using ProjectHotel.Repositories;
using ProjectHotel.Repositories.Implementations;

namespace ProjectHotel;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<FormMainHotel>());
    }

    /// <summary>
    /// Метод создает IoC-контейнер, связывает интерфейсы с заглушками и возвращает готовый контейнер
    /// </summary>
    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();

        // Регистрация справочников
        container.RegisterType<IRoomCategoryRepository, RoomCategoryRepository>(new TransientLifetimeManager());
        container.RegisterType<IHotelRoomRepository, HotelRoomRepository>(new TransientLifetimeManager());
        container.RegisterType<IGuestRepository, GuestRepository>(new TransientLifetimeManager());
        container.RegisterType<IExtraServiceRepository, ExtraServiceRepository>(new TransientLifetimeManager());

        // Регистрация операций
        container.RegisterType<IBookingRepository, BookingRepository>(new TransientLifetimeManager());
        container.RegisterType<IServiceOrderRepository, ServiceOrderRepository>(new TransientLifetimeManager());

        return container;
    }
}