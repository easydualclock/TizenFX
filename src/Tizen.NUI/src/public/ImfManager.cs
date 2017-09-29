/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
using System;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Tizen.NUI
{
    /// <summary>
    /// Specifically manages the ecore input method framework which enables the virtual or hardware keyboards.
    /// </summary>
    public class ImfManager : BaseHandle
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal ImfManager(IntPtr cPtr, bool cMemoryOwn) : base(NDalicManualPINVOKE.ImfManager_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImfManager obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (_keyboardTypeChangedEventCallback != null)
            {
                KeyboardTypeChangedSignal().Disconnect(_keyboardTypeChangedEventCallback);
            }

            if (_imfManagerLanguageChangedEventCallback != null)
            {
                LanguageChangedSignal().Disconnect(_imfManagerLanguageChangedEventCallback);
            }

            if (_imfManagerResizedEventCallback != null)
            {
                ResizedSignal().Disconnect(_imfManagerResizedEventCallback);
            }

            if (_imfManagerStatusChangedEventCallback != null)
            {
                StatusChangedSignal().Disconnect(_imfManagerStatusChangedEventCallback);
            }

            if (_imfManagerEventReceivedEventCallback != null)
            {
                EventReceivedSignal().Disconnect(_imfManagerEventReceivedEventCallback);
            }

            if (_imfManagerActivatedEventCallback != null)
            {
                ActivatedSignal().Disconnect(_imfManagerActivatedEventCallback);
            }

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicManualPINVOKE.delete_ImfManager(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, IntPtr.Zero);
            }

            base.Dispose(type);
        }

        /// <summary>
        /// This structure is used to pass on data from the IMF regarding predictive text.
        /// </summary>
        public class ImfEventData : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal ImfEventData(IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImfEventData obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
            }

            //A Flag to check who called Dispose(). (By User or DisposeQueue)
            private bool isDisposeQueued = false;
            //A Flat to check if it is already disposed.
            protected bool disposed = false;


            ~ImfEventData()
            {
                if (!isDisposeQueued)
                {
                    isDisposeQueued = true;
                    DisposeQueue.Instance.Add(this);
                }
            }

            /// <summary>
            /// The dispose pattern.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            public void Dispose()
            {
                //Throw excpetion if Dispose() is called in separate thread.
                if (!Window.IsInstalled())
                {
                    throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
                }

                if (isDisposeQueued)
                {
                    Dispose(DisposeTypes.Implicit);
                }
                else
                {
                    Dispose(DisposeTypes.Explicit);
                    System.GC.SuppressFinalize(this);
                }
            }

            protected virtual void Dispose(DisposeTypes type)
            {
                if (disposed)
                {
                    return;
                }

                if (type == DisposeTypes.Explicit)
                {
                    //Called by User
                    //Release your own managed resources here.
                    //You should release all of your own disposable objects here.

                }

                //Release your own unmanaged resources here.
                //You should not access any managed member here except static instance.
                //because the execution order of Finalizes is non-deterministic.

                if (swigCPtr.Handle != IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicManualPINVOKE.delete_ImfManager_ImfEventData(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, IntPtr.Zero);
                }

                disposed = true;
            }

            internal static ImfEventData GetImfEventDataFromPtr(IntPtr cPtr)
            {
                ImfEventData ret = new ImfEventData(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }

            /// <summary>
            /// The default constructor.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            public ImfEventData() : this(NDalicManualPINVOKE.new_ImfManager_ImfEventData__SWIG_0(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            /// <summary>
            /// The constructor.
            /// </summary>
            /// <param name="aEventName">The name of the event from the IMF.</param>
            /// <param name="aPredictiveString">The pre-edit or the commit string.</param>
            /// <param name="aCursorOffset">Start the position from the current cursor position to start deleting characters.</param>
            /// <param name="aNumberOfChars">The number of characters to delete from the cursorOffset.</param>
            /// <since_tizen> 3 </since_tizen>
            public ImfEventData(ImfManager.ImfEvent aEventName, string aPredictiveString, int aCursorOffset, int aNumberOfChars) : this(NDalicManualPINVOKE.new_ImfManager_ImfEventData__SWIG_1((int)aEventName, aPredictiveString, aCursorOffset, aNumberOfChars), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            /// <summary>
            /// The pre-edit or the commit string.
            /// </summary>
            //Please do not use! this will be deprecated
            [EditorBrowsable(EditorBrowsableState.Never)]
            /// <since_tizen> 3 </since_tizen>
            public string predictiveString
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_predictiveString_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    string ret = NDalicManualPINVOKE.ImfManager_ImfEventData_predictiveString_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The pre-edit or the commit string.
            /// </summary>
            /// <since_tizen> 4 </since_tizen>
            public string PredictiveString
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_predictiveString_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    string ret = NDalicManualPINVOKE.ImfManager_ImfEventData_predictiveString_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The name of the event from the IMF.
            /// </summary>
            //Please do not use! this will be deprecated
            [EditorBrowsable(EditorBrowsableState.Never)]
            public ImfManager.ImfEvent eventName
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_eventName_set(swigCPtr, (int)value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    ImfManager.ImfEvent ret = (ImfManager.ImfEvent)NDalicManualPINVOKE.ImfManager_ImfEventData_eventName_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The name of the event from the IMF.
            /// </summary>
            /// <since_tizen> 4 </since_tizen>
            public ImfManager.ImfEvent EventName
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_eventName_set(swigCPtr, (int)value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    ImfManager.ImfEvent ret = (ImfManager.ImfEvent)NDalicManualPINVOKE.ImfManager_ImfEventData_eventName_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The start position from the current cursor position to start deleting characters.
            /// </summary>
            //Please do not use! this will be deprecated
            [EditorBrowsable(EditorBrowsableState.Never)]
            public int cursorOffset
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_cursorOffset_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfEventData_cursorOffset_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The start position from the current cursor position to start deleting characters.
            /// </summary>
            /// <since_tizen> 4 </since_tizen>
            public int CursorOffset
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_cursorOffset_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfEventData_cursorOffset_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The number of characters to delete from the cursorOffset.
            /// </summary>
            //Please do not use! this will be deprecated
            [EditorBrowsable(EditorBrowsableState.Never)]
            public int numberOfChars
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_numberOfChars_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfEventData_numberOfChars_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The number of characters to delete from the cursorOffset.
            /// </summary>
            /// <since_tizen> 4 </since_tizen>
            public int NumberOfChars
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_numberOfChars_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfEventData_numberOfChars_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

        }

        /// <summary>
        /// Data required by the IMF from the callback.
        /// </summary>
        public class ImfCallbackData : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal IntPtr GetImfCallbackDataPtr()
            {
                return (IntPtr)swigCPtr;
            }

            internal ImfCallbackData(IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImfCallbackData obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
            }

            //A Flag to check who called Dispose(). (By User or DisposeQueue)
            private bool isDisposeQueued = false;
            //A Flat to check if it is already disposed.
            protected bool disposed = false;


            ~ImfCallbackData()
            {
                if (!isDisposeQueued)
                {
                    isDisposeQueued = true;
                    DisposeQueue.Instance.Add(this);
                }
            }

            /// <summary>
            /// The dispose pattern.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            public void Dispose()
            {
                //Throw excpetion if Dispose() is called in separate thread.
                if (!Window.IsInstalled())
                {
                    throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
                }

                if (isDisposeQueued)
                {
                    Dispose(DisposeTypes.Implicit);
                }
                else
                {
                    Dispose(DisposeTypes.Explicit);
                    System.GC.SuppressFinalize(this);
                }
            }

            protected virtual void Dispose(DisposeTypes type)
            {
                if (disposed)
                {
                    return;
                }

                if (type == DisposeTypes.Explicit)
                {
                    //Called by User
                    //Release your own managed resources here.
                    //You should release all of your own disposable objects here.

                }

                //Release your own unmanaged resources here.
                //You should not access any managed member here except static instance.
                //because the execution order of Finalizes is non-deterministic.

                if (swigCPtr.Handle != IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicManualPINVOKE.delete_ImfManager_ImfCallbackData(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, IntPtr.Zero);
                }

                disposed = true;
            }

            internal static ImfCallbackData GetImfCallbackDataFromPtr(IntPtr cPtr)
            {
                ImfCallbackData ret = new ImfCallbackData(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }

            /// <summary>
            /// The default constructor.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            public ImfCallbackData() : this(NDalicManualPINVOKE.new_ImfManager_ImfCallbackData__SWIG_0(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            /// <summary>
            /// The constructor.
            /// </summary>
            /// <param name="aUpdate">True if the cursor position needs to be updated.</param>
            /// <param name="aCursorPosition">The new position of the cursor.</param>
            /// <param name="aCurrentText">The current text string.</param>
            /// <param name="aPreeditResetRequired">Flag if preedit reset is required.</param>
            /// <since_tizen> 3 </since_tizen>
            public ImfCallbackData(bool aUpdate, int aCursorPosition, string aCurrentText, bool aPreeditResetRequired) : this(NDalicManualPINVOKE.new_ImfManager_ImfCallbackData__SWIG_1(aUpdate, aCursorPosition, aCurrentText, aPreeditResetRequired), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            /// <summary>
            /// The current text string.
            /// </summary>
            //Please do not use! this will be deprecated
            [EditorBrowsable(EditorBrowsableState.Never)]
            public string currentText
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_currentText_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    string ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_currentText_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The current text string.
            /// </summary>
            /// <since_tizen> 4 </since_tizen>
            public string CurrentText
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_currentText_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    string ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_currentText_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The current text string.
            /// </summary>
            //Please do not use! this will be deprecated
            [EditorBrowsable(EditorBrowsableState.Never)]
            public int cursorPosition
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_cursorPosition_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_cursorPosition_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// The current text string.
            /// </summary>
            /// <since_tizen> 4 </since_tizen>
            public int CursorPosition
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_cursorPosition_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_cursorPosition_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// If the cursor position needs to be updated.
            /// </summary>
            //Please do not use! this will be deprecated
            [EditorBrowsable(EditorBrowsableState.Never)]
            public bool update
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_update_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    bool ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_update_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// If the cursor position needs to be updated.
            /// </summary>
            /// <since_tizen> 4 </since_tizen>
            public bool Update
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_update_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    bool ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_update_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// Flags if preedit reset is required.
            /// </summary>
            //Please do not use! this will be deprecated
            [EditorBrowsable(EditorBrowsableState.Never)]
            public bool preeditResetRequired
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_preeditResetRequired_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    bool ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_preeditResetRequired_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            /// <summary>
            /// Flags if preedit reset is required.
            /// </summary>
            /// <since_tizen> 4 </since_tizen>
            public bool PreeditResetRequired
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_preeditResetRequired_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    bool ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_preeditResetRequired_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

        }

        /// <summary>
        /// Retrieves a handle to the instance of the ImfManager.
        /// </summary>
        /// <returns>A handle to the ImfManager.</returns>
        /// <since_tizen> 3 </since_tizen>
        public static ImfManager Get()
        {
            ImfManager ret = new ImfManager(NDalicManualPINVOKE.ImfManager_Get(), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Activates the IMF.<br/>
        /// It means that the text editing is started somewhere.<br/>
        /// If the hardware keyboard isn't connected, then it will show the virtual keyboard.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public void Activate()
        {
            NDalicManualPINVOKE.ImfManager_Activate(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Deactivates the IMF.<br/>
        /// It means that the text editing is finished somewhere.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public void Deactivate()
        {
            NDalicManualPINVOKE.ImfManager_Deactivate(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the restoration status which controls if the keyboard is restored after the focus is lost and then regained.<br/>
        /// If true, then the keyboard will be restored (activated) after focus is regained.
        /// </summary>
        /// <returns>The restoration status.</returns>
        /// <since_tizen> 3 </since_tizen>
        public bool RestoreAfterFocusLost()
        {
            bool ret = NDalicManualPINVOKE.ImfManager_RestoreAfterFocusLost(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Sets the status whether the IMF has to restore the keyboard after losing focus.
        /// </summary>
        /// <param name="toggle">True means that keyboard should be restored after the focus is lost and regained.</param>
        /// <since_tizen> 3 </since_tizen>
        public void SetRestoreAfterFocusLost(bool toggle)
        {
            NDalicManualPINVOKE.ImfManager_SetRestoreAfterFocusLost(swigCPtr, toggle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Sends a message reset to the preedit state or the IMF module.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public new void Reset()
        {
            NDalicManualPINVOKE.ImfManager_Reset(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Notifies the IMF context that the cursor position has changed, required for features like auto-capitalization.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public void NotifyCursorPosition()
        {
            NDalicManualPINVOKE.ImfManager_NotifyCursorPosition(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Sets the cursor position stored in VirtualKeyboard, this is required by the IMF context.
        /// </summary>
        /// <param name="cursorPosition">The position of the cursor.</param>
        /// <since_tizen> 3 </since_tizen>
        public void SetCursorPosition(uint cursorPosition)
        {
            NDalicManualPINVOKE.ImfManager_SetCursorPosition(swigCPtr, cursorPosition);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the cursor position stored in VirtualKeyboard, this is required by the IMF context.
        /// </summary>
        /// <returns>The current position of the cursor.</returns>
        /// <since_tizen> 3 </since_tizen>
        public uint GetCursorPosition()
        {
            uint ret = NDalicManualPINVOKE.ImfManager_GetCursorPosition(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// A method to store the string required by the IMF, this is used to provide predictive word suggestions.
        /// </summary>
        /// <param name="text">The text string surrounding the current cursor point.</param>
        /// <since_tizen> 3 </since_tizen>
        public void SetSurroundingText(string text)
        {
            NDalicManualPINVOKE.ImfManager_SetSurroundingText(swigCPtr, text);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the current text string set within the IMF manager, this is used to offer predictive suggestions.
        /// </summary>
        /// <returns>The surrounding text.</returns>
        /// <since_tizen> 3 </since_tizen>
        public string GetSurroundingText()
        {
            string ret = NDalicManualPINVOKE.ImfManager_GetSurroundingText(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Notifies the IMF context that text input is set to multiline or not.
        /// </summary>
        /// <param name="multiLine">True if multiline text input is used.</param>
        /// <since_tizen> 3 </since_tizen>
        public void NotifyTextInputMultiLine(bool multiLine)
        {
            NDalicManualPINVOKE.ImfManager_NotifyTextInputMultiLine(swigCPtr, multiLine);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Returns the text direction of the keyboard's current input language.
        /// </summary>
        /// <returns>The direction of the text.</returns>
        /// <since_tizen> 3 </since_tizen>
        public ImfManager.TextDirection GetTextDirection()
        {
            ImfManager.TextDirection ret = (ImfManager.TextDirection)NDalicManualPINVOKE.ImfManager_GetTextDirection(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Provides the size and the position of the keyboard.<br/>
        /// The position is relative to whether the keyboard is visible or not.<br/>
        /// If the keyboard is not visible, then the position will be off the screen.<br/>
        /// If the keyboard is not being shown when this method is called, the keyboard is partially setup (IMFContext) to get/>
        /// the values then taken down. So ideally, GetInputMethodArea() should be called after Show().
        /// </summary>
        /// <returns>Rectangle which is keyboard panel x, y, width, height.</returns>
        /// <since_tizen> 3 </since_tizen>
        public Rectangle GetInputMethodArea()
        {
            Rectangle ret = new Rectangle(NDalicManualPINVOKE.ImfManager_GetInputMethodArea(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void ApplyOptions(InputMethodOptions options)
        {
            NDalicManualPINVOKE.ImfManager_ApplyOptions(swigCPtr, InputMethodOptions.getCPtr(options));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Sets up the input-panel specific data.
        /// </summary>
        /// <param name="text">The specific data to be set to the input panel.</param>
        /// <since_tizen> 3 </since_tizen>
        public void SetInputPanelUserData(string text)
        {
            NDalicManualPINVOKE.ImfManager_SetInputPanelUserData(swigCPtr, text);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the specific data of the current active input panel.
        /// </summary>
        /// <param name="text">The specific data to be received from the input panel.</param>
        /// <since_tizen> 3 </since_tizen>
        public void GetInputPanelUserData(out string text)
        {
            NDalicManualPINVOKE.ImfManager_GetInputPanelUserData(swigCPtr, out text);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the state of the current active input panel.
        /// </summary>
        /// <returns>The state of the input panel.</returns>
        /// <since_tizen> 3 </since_tizen>
        public ImfManager.State GetInputPanelState()
        {
            ImfManager.State ret = (ImfManager.State)NDalicManualPINVOKE.ImfManager_GetInputPanelState(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Sets the return key on the input panel to be visible or invisible.<br/>
        /// The default is true.
        /// </summary>
        /// <param name="visible">True if the return key is visible (enabled), false otherwise.</param>
        /// <since_tizen> 3 </since_tizen>
        public void SetReturnKeyState(bool visible)
        {
            NDalicManualPINVOKE.ImfManager_SetReturnKeyState(swigCPtr, visible);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Enables to show the input panel automatically when focused.
        /// </summary>
        /// <param name="enabled">If true, the input panel will be shown when focused.</param>
        /// <since_tizen> 3 </since_tizen>
        public void AutoEnableInputPanel(bool enabled)
        {
            NDalicManualPINVOKE.ImfManager_AutoEnableInputPanel(swigCPtr, enabled);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Shows the input panel.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public void ShowInputPanel()
        {
            NDalicManualPINVOKE.ImfManager_ShowInputPanel(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Hides the input panel.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public void HideInputPanel()
        {
            NDalicManualPINVOKE.ImfManager_HideInputPanel(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the keyboard type.<br/>
        /// The default keyboard type is SoftwareKeyboard.
        /// </summary>
        /// <returns>The keyboard type.</returns>
        /// <since_tizen> 4 </since_tizen>
        public ImfManager.KeyboardType GetKeyboardType()
        {
            ImfManager.KeyboardType ret = (ImfManager.KeyboardType)NDalicManualPINVOKE.ImfManager_GetKeyboardType(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Gets the current language locale of the input panel.<br/>
        /// For example, en_US, en_GB, en_PH, fr_FR, ...
        /// </summary>
        /// <returns>The current language locale of the input panel.</returns>
        /// <since_tizen> 4 </since_tizen>
        public string GetInputPanelLocale()
        {
            string ret = NDalicManualPINVOKE.ImfManager_GetInputPanelLocale(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public ImfManager() : this(NDalicManualPINVOKE.new_ImfManager(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// ImfManager activated event arguments.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class ImfManagerActivatedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void ImfManagerActivatedEventCallbackType(global::System.IntPtr data);
        private ImfManagerActivatedEventCallbackType _imfManagerActivatedEventCallback;
        private event EventHandler<ImfManagerActivatedEventArgs> _imfManagerActivatedEventHandler;

        /// <summary>
        /// ImfManager activated event.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler<ImfManagerActivatedEventArgs> ImfManagerActivated
        {
            add
            {
                if (_imfManagerActivatedEventHandler == null)
                {
                    _imfManagerActivatedEventCallback = OnImfManagerActivated;
                    ActivatedSignal().Connect(_imfManagerActivatedEventCallback);
                }

                _imfManagerActivatedEventHandler += value;
            }
            remove
            {
                _imfManagerActivatedEventHandler -= value;

                if (_imfManagerActivatedEventHandler == null && _imfManagerActivatedEventCallback != null)
                {
                    ActivatedSignal().Disconnect(_imfManagerActivatedEventCallback);
                }
            }
        }

        private void OnImfManagerActivated(global::System.IntPtr data)
        {
            ImfManagerActivatedEventArgs e = new ImfManagerActivatedEventArgs();

            if (data != null)
            {
                e.ImfManager = Registry.GetManagedBaseHandleFromNativePtr(data) as ImfManager;
            }

            if (_imfManagerActivatedEventHandler != null)
            {
                _imfManagerActivatedEventHandler(this, e);
            }
        }

        /// <summary>
        /// ImfManager activated event arguments.
        /// </summary>
        public class ActivatedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void ActivatedEventCallbackType(IntPtr data);
        private ActivatedEventCallbackType _activatedEventCallback;
        private event EventHandler<ActivatedEventArgs> _activatedEventHandler;

        /// <summary>
        /// ImfManager activated.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public event EventHandler<ActivatedEventArgs> Activated
        {
            add
            {
                if (_activatedEventHandler == null)
                {
                    _activatedEventCallback = OnActivated;
                    ActivatedSignal().Connect(_activatedEventCallback);
                }

                _activatedEventHandler += value;
            }
            remove
            {
                _activatedEventHandler -= value;

                if (_activatedEventHandler == null && _activatedEventCallback != null)
                {
                    ActivatedSignal().Disconnect(_activatedEventCallback);
                }
            }
        }

        private void OnActivated(IntPtr data)
        {
            ActivatedEventArgs e = new ActivatedEventArgs();

            if (data != null)
            {
                e.ImfManager = Registry.GetManagedBaseHandleFromNativePtr(data) as ImfManager;
            }

            if (_activatedEventHandler != null)
            {
                _activatedEventHandler(this, e);
            }
        }

        /// <summary>
        /// ImfManager activated signal.
        /// </summary>
        //Please do not use! this will be internal
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ActivatedSignalType ActivatedSignal()
        {
            ActivatedSignalType ret = new ActivatedSignalType(NDalicManualPINVOKE.ImfManager_ActivatedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// ImfManager event received event arguments.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class ImfManagerEventReceivedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        private delegate void ImfManagerEventReceivedEventCallbackType(global::System.IntPtr data);
        private ImfManagerEventReceivedEventCallbackType _imfManagerEventReceivedEventCallback;
        private event EventHandler<ImfManagerEventReceivedEventArgs> _imfManagerEventReceivedEventHandler;

        /// <summary>
        /// ImfManager event received.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler<ImfManagerEventReceivedEventArgs> ImfManagerEventReceived
        {
            add
            {
                if (_imfManagerEventReceivedEventHandler == null)
                {
                    _imfManagerEventReceivedEventCallback = OnImfManagerEventReceived;
                    EventReceivedSignal().Connect(_imfManagerEventReceivedEventCallback);
                }

                _imfManagerEventReceivedEventHandler += value;
            }
            remove
            {
                _imfManagerEventReceivedEventHandler -= value;

                if (_imfManagerEventReceivedEventHandler == null && _imfManagerEventReceivedEventCallback != null)
                {
                    EventReceivedSignal().Disconnect(_imfManagerEventReceivedEventCallback);
                }
            }
        }

        private void OnImfManagerEventReceived(global::System.IntPtr data)
        {
            ImfManagerEventReceivedEventArgs e = new ImfManagerEventReceivedEventArgs();

            if (data != null)
            {
                e.ImfManager = Registry.GetManagedBaseHandleFromNativePtr(data) as ImfManager;
            }

            if (_imfManagerEventReceivedEventHandler != null)
            {
                _imfManagerEventReceivedEventHandler(this, e);
            }
        }

        /// <summary>
        /// ImfManager event received event arguments.
        /// </summary>
        public class EventReceivedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }

            public ImfEventData ImfEventData
            {
                get;
                set;
            }
        }

        private delegate IntPtr EventReceivedEventCallbackType(IntPtr imfManager, IntPtr imfEventData);
        private EventReceivedEventCallbackType _eventReceivedEventCallback;
        private event EventHandlerWithReturnType<object, EventReceivedEventArgs, ImfCallbackData> _eventReceivedEventHandler;

        /// <summary>
        /// ImfManager event received.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public event EventHandlerWithReturnType<object, EventReceivedEventArgs, ImfCallbackData> EventReceived
        {
            add
            {
                if (_eventReceivedEventHandler == null)
                {
                    _eventReceivedEventCallback = OnEventReceived;
                    EventReceivedSignal().Connect(_eventReceivedEventCallback);
                }

                _eventReceivedEventHandler += value;
            }
            remove
            {
                _eventReceivedEventHandler -= value;

                if (_eventReceivedEventHandler == null && _eventReceivedEventCallback != null)
                {
                    EventReceivedSignal().Disconnect(_eventReceivedEventCallback);
                }
            }
        }

        private IntPtr OnEventReceived(IntPtr imfManager, IntPtr imfEventData)
        {
            ImfCallbackData imfCallbackData = null;

            EventReceivedEventArgs e = new EventReceivedEventArgs();

            if (imfManager != null)
            {
                e.ImfManager = Registry.GetManagedBaseHandleFromNativePtr(imfManager) as ImfManager;
            }
            if (imfEventData != null)
            {
                e.ImfEventData = ImfEventData.GetImfEventDataFromPtr(imfEventData);
            }

            if (_eventReceivedEventHandler != null)
            {
                imfCallbackData = _eventReceivedEventHandler(this, e);
            }
            if (imfCallbackData != null)
            {
                return imfCallbackData.GetImfCallbackDataPtr();
            }
            else
            {
                return new ImfCallbackData().GetImfCallbackDataPtr();
            }
        }

        /// <summary>
        /// ImfManager event received signal.
        /// </summary>
	    //Please do not use! this will be internal
	   [EditorBrowsable(EditorBrowsableState.Never)]
        public ImfEventSignalType EventReceivedSignal()
        {
            ImfEventSignalType ret = new ImfEventSignalType(NDalicManualPINVOKE.ImfManager_EventReceivedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// ImfManager status changed event arguments.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class ImfManagerStatusChangedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        private delegate void ImfManagerStatusChangedEventCallbackType(global::System.IntPtr data);
        private ImfManagerStatusChangedEventCallbackType _imfManagerStatusChangedEventCallback;
        private event EventHandler<ImfManagerStatusChangedEventArgs> _imfManagerStatusChangedEventHandler;

        /// <summary>
        /// ImfManager status changed.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler<ImfManagerStatusChangedEventArgs> ImfManagerStatusChanged
        {
            add
            {
                if (_imfManagerStatusChangedEventHandler == null)
                {
                    _imfManagerStatusChangedEventCallback = OnImfManagerStatusChanged;
                    StatusChangedSignal().Connect(_imfManagerStatusChangedEventCallback);
                }

                _imfManagerStatusChangedEventHandler += value;
            }
            remove
            {
                _imfManagerStatusChangedEventHandler -= value;

                if (_imfManagerStatusChangedEventHandler == null && _imfManagerStatusChangedEventCallback != null)
                {
                    StatusChangedSignal().Disconnect(_imfManagerStatusChangedEventCallback);
                }
            }
        }

        private void OnImfManagerStatusChanged(global::System.IntPtr data)
        {
            ImfManagerStatusChangedEventArgs e = new ImfManagerStatusChangedEventArgs();

            if (data != null)
            {
                e.ImfManager = Registry.GetManagedBaseHandleFromNativePtr(data) as ImfManager;
            }

            if (_imfManagerStatusChangedEventHandler != null)
            {
                _imfManagerStatusChangedEventHandler(this, e);
            }
        }

        /// <summary>
        /// ImfManager status changed event arguments.
        /// </summary>
        public class StatusChangedEventArgs : EventArgs
        {
            public bool StatusChanged
            {
                get;
                set;
            }
        }

        private delegate void StatusChangedEventCallbackType(bool statusChanged);
        private StatusChangedEventCallbackType _statusChangedEventCallback;
        private event EventHandler<StatusChangedEventArgs> _statusChangedEventHandler;

        /// <summary>
        /// ImfManager status changed.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public event EventHandler<StatusChangedEventArgs> StatusChanged
        {
            add
            {
                if (_statusChangedEventHandler == null)
                {
                    _statusChangedEventCallback = OnStatusChanged;
                    StatusChangedSignal().Connect(_statusChangedEventCallback);
                }

                _statusChangedEventHandler += value;
            }
            remove
            {
                _statusChangedEventHandler -= value;

                if (_statusChangedEventHandler == null && _statusChangedEventCallback != null)
                {
                    StatusChangedSignal().Disconnect(_statusChangedEventCallback);
                }
            }
        }

        private void OnStatusChanged(bool statusChanged)
        {
            StatusChangedEventArgs e = new StatusChangedEventArgs();

            e.StatusChanged = statusChanged;

            if (_statusChangedEventHandler != null)
            {
                _statusChangedEventHandler(this, e);
            }
        }

        /// <summary>
        /// ImfManager status changed signal.
        /// </summary>
        //Please do not use! this will be internal
        [EditorBrowsable(EditorBrowsableState.Never)]
        public StatusSignalType StatusChangedSignal()
        {
            StatusSignalType ret = new StatusSignalType(NDalicManualPINVOKE.ImfManager_StatusChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// ImfManager resized event arguments.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class ImfManagerResizedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        private delegate void ImfManagerResizedEventCallbackType(IntPtr data);
        private ImfManagerResizedEventCallbackType _imfManagerResizedEventCallback;
        private event EventHandler<ImfManagerResizedEventArgs> _imfManagerResizedEventHandler;

        /// <summary>
        /// ImfManager resized event.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler<ImfManagerResizedEventArgs> ImfManagerResized
        {
            add
            {
                if (_imfManagerResizedEventHandler == null)
                {
                    _imfManagerResizedEventCallback = OnImfManagerResized;
                    ResizedSignal().Connect(_imfManagerResizedEventCallback);
                }

                _imfManagerResizedEventHandler += value;
            }
            remove
            {
                _imfManagerResizedEventHandler -= value;

                if (_imfManagerResizedEventHandler == null && _imfManagerResizedEventCallback != null)
                {
                    ResizedSignal().Disconnect(_imfManagerResizedEventCallback);
                }
            }
        }

        private void OnImfManagerResized(IntPtr data)
        {
            ImfManagerResizedEventArgs e = new ImfManagerResizedEventArgs();

            if (data != null)
            {
                e.ImfManager = Registry.GetManagedBaseHandleFromNativePtr(data) as ImfManager;
            }

            if (_imfManagerResizedEventHandler != null)
            {
                _imfManagerResizedEventHandler(this, e);
            }
        }

        private delegate void ResizedEventCallbackType();
        private ResizedEventCallbackType _resizedEventCallback;
        private event EventHandler _resizedEventHandler;

        /// <summary>
        /// ImfManager resized.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public event EventHandler Resized
        {
            add
            {
                if (_resizedEventHandler == null)
                {
                    _resizedEventCallback = OnResized;
                    ResizedSignal().Connect(_resizedEventCallback);
                }

                _resizedEventHandler += value;
            }
            remove
            {
                _resizedEventHandler -= value;

                if (_resizedEventHandler == null && _resizedEventCallback != null)
                {
                    ResizedSignal().Disconnect(_resizedEventCallback);
                }
            }
        }

        private void OnResized()
        {
            if (_resizedEventHandler != null)
            {
                _resizedEventHandler(this, null);
            }
        }

        /// <summary>
        /// ImfManager resized signal.
        /// </summary>
        //Please do not use! this will be internal
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ImfVoidSignalType ResizedSignal()
        {
            ImfVoidSignalType ret = new ImfVoidSignalType(NDalicManualPINVOKE.ImfManager_ResizedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// ImfManager language changed event arguments.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class ImfManagerLanguageChangedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        private delegate void ImfManagerLanguageChangedEventCallbackType(IntPtr data);
        private ImfManagerLanguageChangedEventCallbackType _imfManagerLanguageChangedEventCallback;
        private event EventHandler<ImfManagerLanguageChangedEventArgs> _imfManagerLanguageChangedEventHandler;

        /// <summary>
        /// ImfManager language changed event.
        /// </summary>
        //Please do not use! this will be deprecated
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler<ImfManagerLanguageChangedEventArgs> ImfManagerLanguageChanged
        {
            add
            {
                if (_imfManagerLanguageChangedEventHandler == null)
                {
                    _imfManagerLanguageChangedEventCallback = OnImfManagerLanguageChanged;
                    LanguageChangedSignal().Connect(_imfManagerLanguageChangedEventCallback);
                }

                _imfManagerLanguageChangedEventHandler += value;
            }
            remove
            {
                _imfManagerLanguageChangedEventHandler -= value;

                if (_imfManagerLanguageChangedEventHandler == null && _imfManagerLanguageChangedEventCallback != null)
                {
                    LanguageChangedSignal().Disconnect(_imfManagerLanguageChangedEventCallback);
                }
            }
        }

        private void OnImfManagerLanguageChanged(IntPtr data)
        {
            ImfManagerLanguageChangedEventArgs e = new ImfManagerLanguageChangedEventArgs();

            if (data != null)
            {
                e.ImfManager = Registry.GetManagedBaseHandleFromNativePtr(data) as ImfManager;
            }

            if (_imfManagerLanguageChangedEventHandler != null)
            {
                _imfManagerLanguageChangedEventHandler(this, e);
            }
        }

        private delegate void LanguageChangedEventCallbackType();
        private LanguageChangedEventCallbackType _languageChangedEventCallback;
        private event EventHandler _languageChangedEventHandler;

        /// <summary>
        /// ImfManager language changed.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public event EventHandler LanguageChanged
        {
            add
            {
                if (_languageChangedEventHandler == null)
                {
                    _languageChangedEventCallback = OnLanguageChanged;
                    LanguageChangedSignal().Connect(_languageChangedEventCallback);
                }

                _languageChangedEventHandler += value;
            }
            remove
            {
                _languageChangedEventHandler -= value;

                if (_languageChangedEventHandler == null && _languageChangedEventCallback != null)
                {
                    LanguageChangedSignal().Disconnect(_languageChangedEventCallback);
                }
            }
        }

        private void OnLanguageChanged()
        {
            if (_languageChangedEventHandler != null)
            {
                _languageChangedEventHandler(this, null);
            }
        }

        /// <summary>
        /// ImfManager language changed signal.
        /// </summary>
        //Please do not use! this will be internal
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ImfVoidSignalType LanguageChangedSignal()
        {
            ImfVoidSignalType ret = new ImfVoidSignalType(NDalicManualPINVOKE.ImfManager_LanguageChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// ImfManager keyboard type changed event arguments.
        /// </summary>
        public class KeyboardTypeChangedEventArgs : EventArgs
        {
            public KeyboardType KeyboardType
            {
                get;
                set;
            }
        }

        private delegate void KeyboardTypeChangedEventCallbackType(KeyboardType type);
        private KeyboardTypeChangedEventCallbackType _keyboardTypeChangedEventCallback;
        private event EventHandler<KeyboardTypeChangedEventArgs> _keyboardTypeChangedEventHandler;

        /// <summary>
        /// ImfManager keyboard type changed.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public event EventHandler<KeyboardTypeChangedEventArgs> KeyboardTypeChanged
        {
            add
            {
                if (_keyboardTypeChangedEventHandler == null)
                {
                    _keyboardTypeChangedEventCallback = OnKeyboardTypeChanged;
                    KeyboardTypeChangedSignal().Connect(_keyboardTypeChangedEventCallback);
                }

                _keyboardTypeChangedEventHandler += value;
            }
            remove
            {
                _keyboardTypeChangedEventHandler -= value;

                if (_keyboardTypeChangedEventHandler == null && _keyboardTypeChangedEventCallback != null)
                {
                    KeyboardTypeChangedSignal().Disconnect(_keyboardTypeChangedEventCallback);
                }
            }
        }

        private void OnKeyboardTypeChanged(KeyboardType type)
        {
            KeyboardTypeChangedEventArgs e = new KeyboardTypeChangedEventArgs();

            e.KeyboardType = type;

            if (_keyboardTypeChangedEventHandler != null)
            {
                _keyboardTypeChangedEventHandler(this, e);
            }
        }

        internal KeyboardTypeSignalType KeyboardTypeChangedSignal()
        {
            KeyboardTypeSignalType ret = new KeyboardTypeSignalType(NDalicManualPINVOKE.ImfManager_KeyboardTypeChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// The direction of the text.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public enum TextDirection
        {
            /// <summary>
            /// Left to right.
            /// </summary>
            LeftToRight,
            /// <summary>
            /// Right to left.
            /// </summary>
            RightToLeft
        }

        /// <summary>
        /// Events that are generated by the IMF.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public enum ImfEvent
        {
            /// <summary>
            /// No event.
            /// </summary>
            Void,
            /// <summary>
            /// Pre-Edit changed.
            /// </summary>
            Preedit,
            /// <summary>
            /// Commit recieved.
            /// </summary>
            Commit,
            /// <summary>
            /// An event to delete a range of characters from the string.
            /// </summary>
            DeleteSurrounding,
            /// <summary>
            /// An event to query string and the cursor position.
            /// </summary>
            GetSurrounding,
            /// <summary>
            /// Private command sent from the input panel.
            /// </summary>
            PrivateCommand
        }

        /// <summary>
        /// Enumeration for the state of the input panel.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public enum State
        {
            /// <summary>
            /// Unknown state.
            /// </summary>
            Default = 0,
            /// <summary>
            /// Input panel is shown.
            /// </summary>
            Show,
            /// <summary>
            /// Input panel is hidden.
            /// </summary>
            Hide,
            /// <summary>
            /// Input panel in process of being shown.
            /// </summary>
            WillShow
        }

        /// <summary>
        /// Enumeration for the types of keyboard.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public enum KeyboardType
        {
            /// <summary>
            /// Software keyboard (virtual keyboard) is default.
            /// </summary>
            SoftwareKeyboard,
            /// <summary>
            /// Hardware keyboard.
            /// </summary>
            HardwareKeyboard
        }
    }
}