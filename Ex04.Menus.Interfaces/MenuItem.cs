using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class MenuItem
    {
        private readonly List<MenuItem> m_MenuItems;

        private readonly List<IRunable> m_RunableObservers = new List<IRunable>();

        public MenuItem(List<MenuItem> i_MenuItems)
        {
            m_MenuItems = i_MenuItems;
        }

        public void AttachObserver(IRunable i_RunableObserver)
        {
            m_RunableObservers.Add(i_RunableObserver);
        }

        public void DetachObserver(IRunable i_RunableObserver)
        {
            m_RunableObservers.Remove(i_RunableObserver);
        }

        public void doWhenItemWasSelected()
        {
            if (m_MenuItems == null)
            {
                showMenu();
            }

            else
            {
                notifyRunableObservers();
            }
        }

        private void showMenu()
        {
            //TODO: show the sub menu
        }

        private void notifyRunableObservers()
        {
            foreach (IRunable observer in m_RunableObservers)
            {
                observer.Run();
            }
        }


    }
}
