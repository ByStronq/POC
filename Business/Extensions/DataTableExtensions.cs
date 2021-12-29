using Business.Models;
using Core.Entities;

namespace Business.Extensions
{
    public static class DataTableExtensions
    {
        public static DatatablesModel.DataTablesResponseParameter<TEntity> List<TEntity>(this DatatablesModel.DataTablesRequestParameter dataTablesRequestParameter, IEnumerable<TEntity> enumerable)
            where TEntity : class, IEntity, new()
        {
            DatatablesModel.DataTablesResponseParameter<TEntity> dataTablesResponseParameter = new DatatablesModel.DataTablesResponseParameter<TEntity>();

            try
            {
                foreach (DatatablesModel.DataTablesRequestParameter.DataTablesRequestColumn ColumnItem in dataTablesRequestParameter.columns)
                {
                    bool isEquality = ColumnItem.IsEquality;

                    string data = ColumnItem.data;
                    string value = ColumnItem.search.value;

                    if (!String.IsNullOrWhiteSpace(value))
                        enumerable = enumerable.Where(data, value, isEquality);
                }

                string[] orderQueryArray = dataTablesRequestParameter.SortOrder.Split(' ');
                string orderPropertyName = orderQueryArray[0];
                bool isDesc = orderQueryArray.Length >= 2 && orderQueryArray[1] == "DESC" ? true : false;

                if (!String.IsNullOrWhiteSpace(orderPropertyName))
                    enumerable = enumerable.OrderBy(x => 0)
                        .OrderBy(orderPropertyName, isDesc, isThenBy: true);
                else enumerable = enumerable.OrderBy(x => 0);

                List<TEntity> SearchEntityList = enumerable.Skip(dataTablesRequestParameter.start).Take(dataTablesRequestParameter.length).ToList();

                dataTablesResponseParameter.draw = dataTablesRequestParameter.draw;

                dataTablesResponseParameter.recordsTotal = enumerable.Count();
                dataTablesResponseParameter.recordsFiltered = dataTablesResponseParameter.recordsTotal;

                dataTablesResponseParameter.data = SearchEntityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dataTablesResponseParameter;
        }
    }
}
