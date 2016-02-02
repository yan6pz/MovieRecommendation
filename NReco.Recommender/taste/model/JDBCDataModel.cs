 /// Licensed to the Apache Software Foundation (ASF) under one or more
 /// contributor license agreements.  See the NOTICE file distributed with
 /// this work for additional information regarding copyright ownership.
 /// The ASF licenses this file to You under the Apache License, Version 2.0
 /// (the "License"); you may not use this file except in compliance with
 /// the License.  You may obtain a copy of the License at
 ///
 ///     http://www.apache.org/licenses/LICENSE-2.0
 ///
 /// Unless required by applicable law or agreed to in writing, software
 /// distributed under the License is distributed on an "AS IS" BASIS,
 /// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 /// See the License for the specific language governing permissions and
 /// limitations under the License.


using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using javax.sql;

using org.apache.mahout.cf.taste.common;
using org.apache.mahout.cf.taste.impl.common;

namespace org.apache.mahout.cf.taste.model {

public interface JDBCDataModel : DataModel {
  
   /// @return {@link DataSource} underlying this model
  DataSource getDataSource();
  
   /// Hmm, should this exist elsewhere? seems like most relevant for a DB implementation, which is not in
   /// memory, which might want to export to memory.
   /// 
   /// @return all user preference data
  FastByIDMap<PreferenceArray> exportWithPrefs() ;
  
  FastByIDMap<FastIDSet> exportWithIDsOnly() ;
  
}

}