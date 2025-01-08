import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
# =============================================================================
Data = pd.read_excel('Responses.xlsx')
# element 0: session index, practice = 1, test = 2
# element 1: catch index, catch = 1, main = 0
# element 2: 
# element 3: number of responding agents
# element 4: right or left hand, right hand = 2, left hand = 1
# element 5: response, right = 1, left = 2, missed = 0
# element 6: response time
# element 7: Dominant color, Blue: DC = 1, Yellow: DC = 2
NP = 9      # number of participants
DataTrain = Data.iloc[:,4:24]       # 20 train trails
DataTest = Data.iloc[:,24:264]      # 240 test trials

# initiate arrays for train data ==============================================
SI_train = np.empty((NP,20))
CI_train = np.empty((NP,20))
NRA_train = np.empty((NP,20))
RLH_train = np.empty((NP,20))
Response_train = np.empty((NP,20))
RT_train = np.empty((NP,20))
DC_train = np.empty((NP,20))
# initiate arrays for test data ==============================================
SI_test = np.empty((NP,240))
CI_test = np.empty((NP,240))
NRA_test = np.empty((NP,240))
RLH_test = np.empty((NP,240))
Response_test = np.empty((NP,240))
RT_test = np.empty((NP,240))
DC_test = np.empty((NP,240))

for a1 in np.arange(0,NP):
    for a2 in np.arange(0,20):
        temp = (DataTrain.iloc[a1,a2]).split(",")
        SI_train[a1,a2] = temp[0]
        CI_train[a1,a2] = temp[1]
        NRA_train[a1,a2] = temp[3]
        RLH_train[a1,a2] = temp[4]
        Response_train[a1,a2] = temp[5]
        Rt_train[a1,a2] = temp[6]
        DC_train[a1,a2] = temp[7]
