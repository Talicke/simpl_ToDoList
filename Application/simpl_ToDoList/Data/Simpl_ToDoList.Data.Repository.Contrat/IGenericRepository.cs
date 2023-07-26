using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpl_ToDoList.Data.Repository.Contrat
{
    public interface IGenericRepository<T> where T: class
    {
        /// <summary>
        /// Permet de créer un entity dans la base de donnée dans la table entity 
        /// </summary>
        /// <param name="supprentity"></param>
        /// <returns></returns>
        Task<T> Creer(T entity);

        /// <summary>
        /// Permet de supprimer un entity dans la base de donnée dans la table entity 
        /// </summary>
        /// <param name="supprentity">entity à supprimer</param>
        /// <returns></returns>
        Task<T> Supprimer(T supprentity);

        /// <summary>
        /// Permet de modifier un entity dans la base de donnée dans la table entity 
        /// </summary>
        /// <param name="modifClient">entity à modifier</param>
        /// <returns></returns>
        Task<T> Modifier(T modifentity);

        /// <summary>
        /// Permet de sélectionner la liste des entitys présents dans la BDD
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> SelecAllAsync();


        /// <summary>
        /// Retourne les infos d'une entity ayant l'iD en param
        /// </summary>
        /// <param name="identity">Identifiant de l'entity</param>
        /// <returns></returns>
        Task<T> SelecAvecId(int identity);

    }
}
