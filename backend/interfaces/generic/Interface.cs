﻿namespace csCY_Avenue.backend.interfaces.generic;

public class Interface
{
}

public interface ICreate<T>
{
    bool Create(T entity, out string message);
}
public interface ISearch<T, TVar>
{
    T? SearchById(int id, TVar? variable, out string message);
    T? SearchByFullName(string fullName, TVar? variable, out string message);
    List<T> SearchAll(string type);
}

public interface IUpdate<T>
{
    bool Update(T entity);
    bool UpdateProfilePicture(T entity, string picture, out string message);
}

public interface IDelete<T>
{
    bool Delete(T entity);
    bool DeleteById(int? id);
}

public interface IAttendance<T>
{
    bool CreateAttendance(T entity);
    bool DeleteEmployeeAttendance(T entity, int id, string fullName, DateTime date);
    bool UpdateEmployeeAttendance(T entity, int id, string fullName, DateTime date);
}